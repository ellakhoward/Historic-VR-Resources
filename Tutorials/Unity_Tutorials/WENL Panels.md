# Approach Panels

 Creating panels that fade into view as the user gets near them

 
## Step 1

Create your model in SketchUp. If you wish to display text, write out your text separately and screenshot, save as either a JPEG or PNG. Do this as many times as you like if you want to divvy up the information among multiple panels

## Step 2

Import your object into Unity and drag it into the environment. Create an empty in the hierarchy and drag your object into it. Create quad(s) and apply image(s). Position them either close in front of, over, or close behind object depending on what looks best and is most practical for the object. Set the material rendering to transparent for each quad AFTER each image is applied. Put each quad into the empty along with the object for organization and to allow for the creation of a general prefab.

## Step 3

Apply the following script to the object: 

### SCRIPT
using UnityEngine;
using System.Collections;

public class NewspaperInteraction : MonoBehaviour
{
    [Header("Newspaper Display Settings")]
    public GameObject[] newspaperQuads;     // The quads with newspaper JPGs
    public float detectionRadius = 2.5f;    // How close the player needs to be
    public float fadeSpeed = 1.5f;          // How quickly to fade in/out
    
    [Header("Optional Audio")]
    public AudioSource audioSource;
    public AudioClip paperSound;            // Optional rustle sound
    
    private bool isPlayerNear = false;
    private bool isFading = false;
    private Transform playerCamera;
    
    void Start()
    {
        // Find the player camera (typically the main camera in VR)
        playerCamera = Camera.main.transform;
        
        // Make sure all newspaper quads are initially invisible
        foreach (GameObject quad in newspaperQuads)
        {
            if (quad != null)
            {
                // Get the renderer to control opacity
                Renderer renderer = quad.GetComponent<Renderer>();
                if (renderer != null)
                {
                    // Set initial alpha to 0 (fully transparent)
                    Color color = renderer.material.color;
                    color.a = 0f;
                    renderer.material.color = color;
                }
                
                // Make sure the GameObject is active but invisible
                quad.SetActive(true);
            }
        }
    }
    
    void Update()
    {
        if (playerCamera == null) return;
        
        // Check distance to player
        float distanceToPlayer = Vector3.Distance(transform.position, playerCamera.position);
        
        // Determine if player is near enough
        bool shouldBeNear = (distanceToPlayer <= detectionRadius);
        
        // If state has changed and not already fading
        if (shouldBeNear != isPlayerNear && !isFading)
        {
            isPlayerNear = shouldBeNear;
            
            // Start fading in or out
            StartCoroutine(FadeNewspapers(isPlayerNear));
            
            // Play sound effect if available
            if (isPlayerNear && audioSource != null && paperSound != null)
            {
                audioSource.clip = paperSound;
                audioSource.Play();
            }
        }
    }
    
    IEnumerator FadeNewspapers(bool fadeIn)
    {
        isFading = true;
        
        // Target alpha value
        float targetAlpha = fadeIn ? 1f : 0f;
        
        // Current alpha values for each quad
        float[] currentAlphas = new float[newspaperQuads.Length];
        Renderer[] renderers = new Renderer[newspaperQuads.Length];
        
        // Get all renderers and current alpha values
        for (int i = 0; i < newspaperQuads.Length; i++)
        {
            if (newspaperQuads[i] != null)
            {
                renderers[i] = newspaperQuads[i].GetComponent<Renderer>();
                if (renderers[i] != null)
                {
                    currentAlphas[i] = renderers[i].material.color.a;
                }
            }
        }
        
        // Gradually change alpha
        float elapsedTime = 0f;
        while (elapsedTime < 1f)
        {
            elapsedTime += Time.deltaTime * fadeSpeed;
            float t = Mathf.Clamp01(elapsedTime); // Normalized time (0-1)
            
            // Update alpha for each quad
            for (int i = 0; i < newspaperQuads.Length; i++)
            {
                if (renderers[i] != null)
                {
                    // Get current color
                    Color color = renderers[i].material.color;
                    
                    // Interpolate alpha
                    color.a = Mathf.Lerp(currentAlphas[i], targetAlpha, t);
                    
                    // Apply new color with updated alpha
                    renderers[i].material.color = color;
                }
            }
            
            yield return null;
        }
        
        // Ensure final alpha is set exactly
        for (int i = 0; i < newspaperQuads.Length; i++)
        {
            if (renderers[i] != null)
            {
                Color color = renderers[i].material.color;
                color.a = targetAlpha;
                renderers[i].material.color = color;
            }
        }
        
        isFading = false;
    }
    
    // Optional: Visual indicator of trigger radius in editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}

## Step 4

Add each of your quads to the ‘newspaper quads’ section, play with settings and quad position till they are just right.
 

