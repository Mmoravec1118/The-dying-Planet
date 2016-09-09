using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinControllerScript : MonoBehaviour
{
    public Text text;
	// Use this for initialization
	void Start ()
    {
        if (LevelSelectScript.levelSelectScript.GetLevelsCompleted() == 0)
        {
            text.text = "No Levels Completed";
        }
        if (LevelSelectScript.levelSelectScript.GetLevelsCompleted() == 1)
        {
            text.text = "While you could have brought more supplies, your planet is still thankful to have enough to get by. Good job?";
        }
        else if (LevelSelectScript.levelSelectScript.GetLevelsCompleted() == 2)
        {
            text.text = "Your efforts paid off. The resource you collected allowed your planet to start anew. Well done.";
        }
        else if (LevelSelectScript.levelSelectScript.GetLevelsCompleted() == 3)
        {
            text.text = "Wow you went above and beyond. You have collected enough resources to last for generations! Great Job!";
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.anyKeyDown == true)
        {
            SceneManager.LoadScene("Main Menu");
        }
	}
}
