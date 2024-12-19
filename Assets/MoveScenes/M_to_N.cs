using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class M_to_N : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("N example");
    }
}
