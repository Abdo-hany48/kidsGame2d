using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_to_T : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("T example");
    }
}
