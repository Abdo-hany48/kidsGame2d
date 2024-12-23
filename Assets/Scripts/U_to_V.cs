using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class U_to_V : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("V example");
    }
}
