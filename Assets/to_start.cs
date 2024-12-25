using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_start : MonoBehaviour 
{
    public void goToPreviousScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
