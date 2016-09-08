using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    float speed = 5f;
    Vector2 initialVelocity;
    Vector2 velocity;
    bool canSpawn = true;

    // Use this for initialization
    void Start ()
    {
        // start the ball in an upward direction
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));

        initialVelocity = new Vector2(Random.Range(-5f, 5f), speed);
        GetComponent<Rigidbody2D>().velocity = initialVelocity;
	}
	
	// Update is called once per frame
	void Update ()
    {
	  if (Input.GetKeyDown("space") && canSpawn)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5f, 5f), speed));
            canSpawn = false;
            Debug.Log("Works");
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        // If the ball collides with a block, ball should bounce
        //if (coll.gameObject.tag == "Block")
        //{
        //    //rb = this.gameObject.GetComponent<Rigidbody2D>();
        //    //rb.velocity.Set(rb.velocity.x, 0);
        //    //gameObject.GetComponent<Rigidbody2D>().velocity.Set(this.gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f);
        //    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f);
        //    //Destroy(gameObject);
        //}

        if (coll.gameObject.tag == "TopBorder")
        {
            velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.y *= -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }

        if (coll.gameObject.tag == "SideBorder")
        {
            velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.x *= -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
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
