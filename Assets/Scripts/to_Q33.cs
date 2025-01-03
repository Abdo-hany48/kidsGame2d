﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class to_Q33 : MonoBehaviour
{
    public bool isCorrectAnswer; // Set this to true for the correct answer button

    public void OnAnswerSelected()
    {
        // Increment score if the answer is correct
        if (isCorrectAnswer)
        {
            QuizScoreManager2.Instance.IncrementScore();
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
            SceneManager.LoadScene("Quiz2 Q3");
        }
        //else
        {
            //  Debug.LogWarning("No next scene available.");
        }
    }
}
