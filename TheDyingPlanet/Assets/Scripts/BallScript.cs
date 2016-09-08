using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    float speed = 5f;
    Vector2 initialVelocity;
    Vector2 velocity;
    bool canSpawn = false;
    LevelControllerScript levelControlScript;

    // Use this for initialization
    void Start ()
    {
        // start the ball in an upward direction
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));

        levelControlScript = GetComponent<LevelControllerScript>();
        initialVelocity = new Vector2(Random.Range(-5f, 5f), speed);
        GetComponent<Rigidbody2D>().velocity = initialVelocity;
	}
	
	// Update is called once per frame
	void Update ()
    {

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

        if (coll.gameObject.tag == "BottomBorder")
        {
            Destroy(this.gameObject);
        }
    }
}
