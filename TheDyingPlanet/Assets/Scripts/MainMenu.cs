using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        PlayerPrefs.SetInt("Level1 Complete", 0);
        PlayerPrefs.SetInt("Level2 Complete", 0);
        PlayerPrefs.SetInt("Level3 Complete", 0);
    }
}
