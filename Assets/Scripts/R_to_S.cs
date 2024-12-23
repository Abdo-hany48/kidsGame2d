using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class R_to_S : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("S example");
    }
}
