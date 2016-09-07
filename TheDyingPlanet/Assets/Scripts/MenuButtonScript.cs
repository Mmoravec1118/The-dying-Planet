﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{

    public int level;

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
