using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizScoreManager3 : MonoBehaviour
{
    public static QuizScoreManager3 Instance; // Singleton instance

    private int score3 = 0; // Current score
    [SerializeField] private Text scoreText; // UI Text for displaying the score

    private void Awake()
    {
        // Singleton pattern to ensure one instance
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
        AssignScoreText();
        UpdateScoreText();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the loaded scene is "Quiz1 Q1"
        if (scene.name == "Quiz3 Q1")
        {
            ResetScore(); // Reset the score to zero
        }

        AssignScoreText();
        UpdateScoreText();
    }

    private void AssignScoreText()
    {
        // Try to find the Text object named "ScoreText" in the current scene
        GameObject textObject = GameObject.Find("ScoreText");
        if (textObject != null)
        {
            scoreText = textObject.GetComponent<Text>();
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score3;
        }
    }

    public void IncrementScore()
    {
        score3++; // Increase score by 1
        UpdateScoreText();
    }

    public int GetScore()
    {
        return score3;
    }

    public void ResetScore()
    {
        score3 = 0; // Reset the score to zero
        UpdateScoreText();
    }
}