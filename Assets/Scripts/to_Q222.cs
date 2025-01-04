using UnityEngine;
using UnityEngine.SceneManagement;

public class to_Q222 : MonoBehaviour
{
    public bool isCorrectAnswer; // Set this to true for the correct answer button

    public void OnAnswerSelected()
    {
        // Increment score if the answer is correct
        if (isCorrectAnswer)
        {
            QuizScoreManager3.Instance.IncrementScore();
        }

        // Navigate to the next scene
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if there is a next scene
        //if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene("Quiz3 Q2");
        }
        //else
        {
            //  Debug.LogWarning("No next scene available.");
        }
    }
}
