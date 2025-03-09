using UnityEngine;
using System.Collections;

public class PictureFrameInteraction : MonoBehaviour
{
    [Header("Interaction Settings")]
    public float activationDistance = 2.5f;
    public GameObject photoObject;
    public float fadeSpeed = 1.5f;
    
    [Header("Optional Audio")]
    public AudioSource audioSource;
    public AudioClip descriptionAudio;
    
    private Transform playerCamera;
    private bool isActive = false;
    private bool isFading = false;
    private Renderer photoRenderer;
    private Color originalColor;
    
    void Start()
    {
        // Find the player camera
        playerCamera = Camera.main.transform;
        
        // Get renderer and material of photo
        if (photoObject != null)
        {
            photoRenderer = photoObject.GetComponent<Renderer>();
            if (photoRenderer != null)
            {
                // Store original color
                originalColor = photoRenderer.material.color;
                // Set initial color to transparent
                Color startColor = originalColor;
                startColor.a = 0;
                photoRenderer.material.color = startColor;
            }
        }
    }
    
    void Update()
    {
        if (playerCamera == null || photoRenderer == null) return;
        
        // Check distance to player
        float distanceToPlayer = Vector3.Distance(transform.position, playerCamera.position);
        
        // Determine if photo should be shown
        bool shouldBeActive = (distanceToPlayer <= activationDistance);
        
        // Handle state change
        if (shouldBeActive != isActive && !isFading)
        {
            isActive = shouldBeActive;
            StartCoroutine(FadePhoto(isActive));
            
            // Play/stop audio
            if (audioSource != null && descriptionAudio != null)
            {
                if (isActive && !audioSource.isPlaying)
                {
                    audioSource.clip = descriptionAudio;
                    audioSource.Play();
                }
                else if (!isActive && audioSource.isPlaying)
                {
                    audioSource.Stop();
                }
            }
        }
    }
    
    IEnumerator FadePhoto(bool fadeIn)
    {
        isFading = true;
        
        // Target colors
        Color targetColor = originalColor;
        targetColor.a = fadeIn ? 1f : 0f;
        Color currentColor = photoRenderer.material.color;
        
        // Fade gradually
        float elapsedTime = 0;
        while (elapsedTime < 1f)
        {
            elapsedTime += Time.deltaTime * fadeSpeed;
            photoRenderer.material.color = Color.Lerp(currentColor, targetColor, elapsedTime);
            yield return null;
        }
        
        // Ensure final color is set
        photoRenderer.material.color = targetColor;
        
        isFading = false;
    }
    
    // Visual indication of activation zone in editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, activationDistance);
    }
}