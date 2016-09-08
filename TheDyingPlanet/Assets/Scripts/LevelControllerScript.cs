using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControllerScript : MonoBehaviour {

    public static LevelControllerScript gameManager = null;
    private GameObject[] blockArray;
    public GameObject[] playerShips = new GameObject[2];
    public GameObject flatShip;
    public GameObject curvedShip;
    public Text livesText;
    public Text ballsText;
    private int blockCount;
    private int lives = 3;
    private int balls = 4;
    private GameObject playerPaddle;
    
    // Use this for initialization
	void Start ()
    {
        // makes sure there will only be one instance of the level controller script
        if (gameManager == null)
        {
            gameManager = this;
        }
        else if (gameManager != this)
        {
            Destroy(this);
        }

        SpawnPaddle();
        livesText.text = "Lives" + lives;
        ballsText.text = "Balls: " + balls;
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
                PlayerPrefs.SetInt("Level1 Complete", 1);
                SceneManager.LoadScene("DecisionScene");
            }
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                PlayerPrefs.SetInt("Level2 Complete", 1);
                SceneManager.LoadScene("DecisionScene");
            }
            if (SceneManager.GetActiveScene().name == "Level 3")
            {
                PlayerPrefs.SetInt("Level3 Complete", 1);
                SceneManager.LoadScene("DecisionScene");
            }
        }

        // go to death scene when lives or balls reach 0
        if (lives <= 0 || balls <= 0)
        {

        }
	}

    void SpawnPaddle()
    {
        // based on the players input spawn the appropriate ship
        if (PlayerPrefs.GetInt("CharacterChoice") == 0)
        {
            playerPaddle = Instantiate(flatShip, transform.position, Quaternion.identity) as GameObject;
        }
        else if (PlayerPrefs.GetInt("CharacterChoice") == 1)
        {
            playerPaddle = Instantiate(curvedShip, transform.position, Quaternion.identity) as GameObject;
        }
    }



    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Destroy(playerPaddle);
        SpawnPaddle();
        Debug.Log(lives);
    }

    public void LoseBall()
    {
        balls--;
        ballsText.text = "Balls: " + balls;
        Debug.Log(balls);
    }
}
