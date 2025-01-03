using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public static Timer2 Instance; // Singleton instance
    private float totalTime = 0f; // Total time across all quiz scenes
    private bool isTiming = false; // Control when to start and stop timing

    [SerializeField] private Text timeCountText; // UI Text for displaying the time

    private void Awake()
    {
        // Singleton pattern to ensure only one Timer instance
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Start timing when the quiz begins
        if (SceneManager.GetActiveScene().name == "Quiz2 Q1")
        {
            ResetTimer(); // Reset timer when starting a new quiz
            isTiming = true;
        }

        // Assign the timeCountText when the scene loads
        AssignTimeCountText();
    }

    private void Update()
    {
        // Increment the timer only if timing is active
        if (isTiming)
        {
            totalTime += Time.deltaTime;

            // Update the UI if a Text component is set
            if (timeCountText != null)
            {
                timeCountText.text = "Time: " + totalTime.ToString("F2");
            }
        }

        // Check if we reached the end scene
        if (SceneManager.GetActiveScene().name == "Quiz2 End")
        {
            isTiming = false; // Stop timing
            DisplayFinalTime(); // Display the total time
        }
    }

    public void DisplayFinalTime()
    {
        // Find the Text component in the end scene to display the final time
        Text endSceneText = GameObject.Find("FinalTimeText").GetComponent<Text>();
        if (endSceneText != null)
        {
            endSceneText.text = "Total Time: " + totalTime.ToString("F2") + " seconds";
        }
    }

    private void OnEnable()
    {
        // Subscribe to scene loading event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe from scene loading event
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Assign the timeCountText for the new scene
        AssignTimeCountText();

        // Restart timer if back to the first scene
        if (scene.name == "Quiz2 Q1")
        {
            ResetTimer();
            isTiming = true;
        }
    }

    private void AssignTimeCountText()
    {
        // Try to find the Text object in the new scene
        GameObject textObject = GameObject.Find("TimeCountText");
        if (textObject != null)
        {
            timeCountText = textObject.GetComponent<Text>();
        }
    }

    public void ResetTimer()
    {
        totalTime = 0f; // Reset the total time
        isTiming = false;
    }
}
