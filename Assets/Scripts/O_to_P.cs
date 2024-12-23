using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class O_to_P : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("P example");
    }
}
