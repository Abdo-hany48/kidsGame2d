using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class C_to_D : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("D example");
    }
}
