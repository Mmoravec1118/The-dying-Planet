using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {

    public static LevelSelectScript levelSelectScript = null;
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    int levelsCompleted = 0;

    // Use this for initialization
	void Start ()
    {
        // makes sure there will only be one instance of the level select script
        if (levelSelectScript == null)
        {
            levelSelectScript = this;
        }
        else if (levelSelectScript != this)
        {
            Destroy(this);
        }

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

    public int GetLevelsCompleted()
    {
        return levelsCompleted;
    }
}
