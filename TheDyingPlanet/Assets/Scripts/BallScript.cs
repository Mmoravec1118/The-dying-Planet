using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
    //public Rigidbody2D rb;
    void OnCollisionEnter2D(Collision2D coll)
    {
        // If the ball collides with a block, ball shoudl bounce
        if (coll.gameObject.tag == "Block")
        {
            //rb = this.gameObject.GetComponent<Rigidbody2D>();
            //rb.velocity.Set(rb.velocity.x, 0);
            //gameObject.GetComponent<Rigidbody2D>().velocity.Set(this.gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f);
            //Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start ()
    {
        // start the ball in an upward direction
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
	}
	
	// Update is called once per frame
	void Update ()
    {
	  
	}

    //void OnCollisionEnter2D(Collision2D coll)
    //{
    //    // if the ball collides with a block, apply a downward velocity
    //    if (coll.gameObject.tag == "Block")
    //    {
    //        coll.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100));
    //    }
    //}
}
