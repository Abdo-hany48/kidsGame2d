using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class P_to_Q : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("Q example");
    }
}
