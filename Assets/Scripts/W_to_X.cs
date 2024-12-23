using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class W_to_X : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("X example");
    }
}
