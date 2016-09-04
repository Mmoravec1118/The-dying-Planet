using UnityEngine;
using System.Collections;

public class BrickScrpit : MonoBehaviour
{

    void OnCollisionEnter2D (Collision2D coll)
    {
        // if a ball collides with a block, destroy the block
        if (coll.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
	
}
