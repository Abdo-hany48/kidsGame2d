using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F_to_G : MonoBehaviour 
{


    public void goToNextScene()
    {
        SceneManager.LoadScene("G example");
    }
}
