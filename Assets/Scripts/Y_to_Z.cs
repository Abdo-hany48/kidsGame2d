using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Y_to_Z : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("Z example");
    }
}
