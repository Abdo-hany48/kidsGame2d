using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class I_to_J : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("J example");
    }
}
