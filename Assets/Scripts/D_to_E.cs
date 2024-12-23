using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D_to_E : MonoBehaviour 
{

    public void goToNextScene()
    {
        SceneManager.LoadScene("E example");
    }
}
