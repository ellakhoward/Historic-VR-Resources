using UnityEngine;
using System.Collections;

public class ViewingStationTrigger : MonoBehaviour
{
    public Material presentDaySkybox;     // Your panorama material
    public float fadeSpeed = 1.5f;        // How quickly to transition
    public AudioClip locationAudio;       // Optional narration
    
    private Material originalSkybox;      // The original skybox of your scene
    private bool isPlayerOnStation = false;
    private bool isTransitioning = false;
    private AudioSource audioSource;
    
    void Start()
    {
        // Store original skybox
        originalSkybox = RenderSettings.skybox;
        
        // Get audio source
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPlayerOnStation)
        {
            isPlayerOnStation = true;
            
            // Change to panorama view
            StartCoroutine(TransitionSkybox(true));
            
            // Play audio narration if available
            if (audioSource != null && locationAudio != null)
            {
                audioSource.clip = locationAudio;
                audioSource.Play();
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isPlayerOnStation)
        {
            isPlayerOnStation = false;
            
            // Change back to original view
            StartCoroutine(TransitionSkybox(false));
            
            // Stop audio
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
    
    IEnumerator TransitionSkybox(bool toPresentDay)
    {
        if (isTransitioning) yield break;
        
        isTransitioning = true;
        
        // Set target skybox
        Material targetSkybox = toPresentDay ? presentDaySkybox : originalSkybox;
        
        // Simple transition - just swap skyboxes
        RenderSettings.skybox = targetSkybox;
        
        // Wait a moment to prevent rapid toggling
        yield return new WaitForSeconds(0.5f);
        
        isTransitioning = false;
    }
    
    // Visual indicator in editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, GetComponent<BoxCollider>()?.size.y ?? 1f);
    }
}