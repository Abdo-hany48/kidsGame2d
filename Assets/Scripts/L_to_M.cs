using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class L_to_M : MonoBehaviour
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("M example");
    }
}
