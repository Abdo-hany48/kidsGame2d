using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class T_to_U : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("U example");
    }
}
