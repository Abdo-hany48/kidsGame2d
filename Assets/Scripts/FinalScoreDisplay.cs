using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text finalScoreText; // Assign in Unity Editor

    private void Start()
    {
        if (finalScoreText != null)
        {
            finalScoreText.text = "Total Score: " + QuizScoreManager.Instance.GetScore() + "/5";
        }
    }
}