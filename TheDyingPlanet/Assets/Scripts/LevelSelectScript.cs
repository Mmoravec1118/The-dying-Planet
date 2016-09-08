using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {

    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    int levelsCompleted = 0;

    // Use this for initialization
	void Start ()
    {
	    if (PlayerPrefs.GetInt("Level1 Complete") == 1)
        {
            level1Button.interactable = false;
            levelsCompleted += 1;
        }
        if (PlayerPrefs.GetInt("Level2 Complete") == 1)
        {
            level2Button.interactable = false;
            levelsCompleted += 1;
        }
        if (PlayerPrefs.GetInt("Level3 Complete") == 1)
        {
            level3Button.interactable = false;
            levelsCompleted += 1;
        }
        


	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
