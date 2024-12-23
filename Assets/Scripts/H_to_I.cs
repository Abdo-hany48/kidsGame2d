using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class H_to_I : MonoBehaviour
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("I example");
    }
}
