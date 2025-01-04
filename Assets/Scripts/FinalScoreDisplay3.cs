using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay3 : MonoBehaviour
{
    [SerializeField] private Text finalScoreText; // Assign in Unity Editor

    private void Start()
    {
        if (finalScoreText != null)
        {
            finalScoreText.text = "Total Score: " + QuizScoreManager3.Instance.GetScore() + "/5";
        }
    }
}