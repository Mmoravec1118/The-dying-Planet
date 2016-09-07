using UnityEngine;
using System.Collections;

public class CharacterSpawn : MonoBehaviour
{

    // an arrary of game objects for each possible ship selection
    public GameObject[] playerShips = new GameObject[2];

    // Use this for initialization
    void Start ()
    {
        // based on the players input spawn the appropriate ship
        if (PlayerPrefs.GetInt("CharacterChoice") == 0)
        {
            GameObject.Instantiate(playerShips[0], transform.position, transform.rotation);
        }
        else if (PlayerPrefs.GetInt("CharacterChoice") == 1)
        {
            GameObject.Instantiate(playerShips[1], transform.position, transform.rotation);
        }
	}
}
