using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // start the ball in an upward direction
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the ball collides with a block, apply a downward velocity
        if (coll.gameObject.tag == "Block")
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100));
        }
    }
}
