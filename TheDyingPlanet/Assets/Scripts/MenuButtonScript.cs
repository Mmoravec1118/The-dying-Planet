using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    public int level;

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void HomePlanet()
    {
        SceneManager.LoadScene("Win Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

