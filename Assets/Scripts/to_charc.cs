﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class to_charc : MonoBehaviour
{
    public void goToNextScene()
    {
        SceneManager.LoadScene("SelectCharacter");
    }
}