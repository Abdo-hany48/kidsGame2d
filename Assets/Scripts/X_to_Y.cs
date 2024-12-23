using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class X_to_Y : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("Y example");
    }
}
