using UnityEngine;
using System.Collections;

public class SpaceshipMovement : MonoBehaviour
{
    public float shipSpeed;
    public GameObject ball;
    float horizontalVelocity;
    Vector2 ballVelocity = new Vector2(0, 100);
    Vector2 tempVelocity;
    bool canSpawn = true;
    	
	// Update is called once per frame
	void Update ()
    {
        // store the ships horizontal input axis
        horizontalVelocity = Input.GetAxisRaw("Horizontal");
        
        // prevents ship from going out of bounds
        if (horizontalVelocity > 0f && gameObject.GetComponent<Transform>().position.x > 5.2f ||
            horizontalVelocity < 0f && gameObject.GetComponent<Transform>().position.x < -5.2f)
        {
            horizontalVelocity = 0f;
        }

        // calculate the velocity of the ship based on the horizontal input 
        tempVelocity = new Vector2(horizontalVelocity * shipSpeed, 0);
        tempVelocity.Normalize();
        tempVelocity *= shipSpeed;

        // apply the velocity to the ships rigid body
        GetComponent<Rigidbody2D>().velocity = tempVelocity;

        SpawnBall();
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (ball.gameObject.tag == "Ball")
        {
            ball.GetComponent<Rigidbody2D>().AddForce(ballVelocity);
        }
    }

    void SpawnBall ()
    {
        if (Input.GetKeyDown("space") && canSpawn)
        {
            Instantiate(ball, transform.position, transform.rotation);
            canSpawn = false;
        }

        if (ball.transform.position.y < -5.5)
        {
            Destroy(ball);
            canSpawn = true;
            Debug.Log("Pwnt");
        }
    }
}
