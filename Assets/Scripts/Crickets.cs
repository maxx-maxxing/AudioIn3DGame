using UnityEngine;

public class Crickets : MonoBehaviour
{
    public AudioSource audioSource;
    public float stopDistance;

    private Transform player;
    private float defaultVolume;

    void Start()
    {
        defaultVolume = audioSource.volume;
        player = FindFirstObjectByType<PlayerController>().transform;
    }

    void Update()
    {
        if (player == null)
        {
            return;
        }

        float dist = Vector3.Distance(transform.position, player.position);
    }
}
