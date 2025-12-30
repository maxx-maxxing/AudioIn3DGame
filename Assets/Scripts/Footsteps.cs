using UnityEngine;

public class Footsteps : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.velocity.magnitude > footstepThreshold)
        {
            if (Time.time - lastFootstepTime > footstepRate)
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
            }
        }
    }

    public AudioClip[] footstepClips;
    public AudioSource audioSource;
    
    public CharacterController controller;

    public float footstepThreshold;
    public float footstepRate;
    private float lastFootstepTime;
}
