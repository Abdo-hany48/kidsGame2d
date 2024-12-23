using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_to_C : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("C example");
    }
}
