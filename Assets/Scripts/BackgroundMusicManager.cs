using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioClip backgroundMusic; // Assign your music clip in the Inspector
    private AudioSource audioSource;

    public static BackgroundMusicManager Instance { get; private set; } // Singleton Instance

    private void Awake()
    {
        // Ensure only one instance of the manager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this GameObject across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
            return;
        }

        // Set up the AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true; // Enable looping
        audioSource.playOnAwake = false; // Avoid auto-play on load
        audioSource.volume = 0.5f; // Set initial volume
    }

    private void Start()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play(); // Start playing the music
        }
    }

    public void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = Mathf.Clamp01(volume); // Clamp the volume between 0 and 1
        }
    }

    public float GetVolume()
    {
        return audioSource != null ? audioSource.volume : 0;
    }
}
