using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelControllerScript : MonoBehaviour {

	private GameObject[] blockArray;
    private int blockCount;
    private int lives;
    private int balls;
    
    // Use this for initialization
	void Start ()
    {
        lives = 3;
        balls = 3;
	}
	
	// Update is called once per frame
	void Update () 
    {
        blockArray = GameObject.FindGameObjectsWithTag("Block");
        blockCount = blockArray.Length;

        // initiates next level if all blocks are destroyed
        if (blockCount <= 0)
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
        }

        // go to death scene when lives or balls reach 0
        if (lives <= 0 || balls <= 0)
        {

        }
	}

    void LoseLife()
    {
        lives -= 1;
    }

    void LoseBall()
    {
        balls -= 1;
    }
}
