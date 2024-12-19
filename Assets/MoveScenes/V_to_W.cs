using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class V_to_W : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("W example");
    }
}
