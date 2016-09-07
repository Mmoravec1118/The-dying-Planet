using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour
{

    // destroy the block if the ball collides with it
    void OnCollisionEnter2D (Collision2D coll)
    {
        // if a ball collides with a block, destroy the block
        if (coll.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
	
}
