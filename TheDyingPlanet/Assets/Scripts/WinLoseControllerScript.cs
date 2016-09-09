using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinLoseControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.anyKeyDown == true)
        {
            if (SceneManager.GetActiveScene().name == "Win Scene")
            {
                SceneManager.LoadScene("Level Select");
            }

            else
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
	}
}
