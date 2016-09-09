using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectControllerScript : MonoBehaviour {

    public int LevelInt;
    
    // Use this for initialization
	void Start () 
    {
        // placeholding while implementation of level select canvas is incomplete
        LevelInt = 5;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    switch (LevelInt)
        {
            case 0:
                SceneManager.LoadScene("Main Menu");
                break;
            case 1:
                SceneManager.LoadScene("Level 1");
                break;
            case 2:
                SceneManager.LoadScene("Level 2");
                break;
            case 3:
                SceneManager.LoadScene("Level 3");
                break;
            case 4:
                SceneManager.LoadScene("Home Planet");
                break;
            case 5:
                break;
        }
	}
}
