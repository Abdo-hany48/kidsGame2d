﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_character : MonoBehaviour 
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("SelectingCharacters");
    }
}
