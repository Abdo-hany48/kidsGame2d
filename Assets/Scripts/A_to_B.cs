using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_to_B : MonoBehaviour 
{
	public void goToNextScene()
	{
		SceneManager.LoadScene("B example");
	}
}
