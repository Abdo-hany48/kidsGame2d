using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay2 : MonoBehaviour
{
    [SerializeField] private Text finalScoreText; // Assign in Unity Editor

    private void Start()
    {
        if (finalScoreText != null)
        {
            finalScoreText.text = "Total Score: " + QuizScoreManager2.Instance.GetScore() + "/4";
        }
    }
}