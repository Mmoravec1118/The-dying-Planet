using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelControllerScript : MonoBehaviour {

	private GameObject[] blockArray;
    private int blockCount;
    
    // Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        blockArray = GameObject.FindGameObjectsWithTag("Block");
        blockCount = blockArray.Length;

        // initiates next level if all blocks are destroyed
        if (blockCount <= 0)
        {
            /*if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            } */

            // placeholding for text that follows winning
            SceneManager.LoadScene("Win Scene");
        }
	}
}
