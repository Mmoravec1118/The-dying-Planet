using UnityEngine;
using System.Collections;

public class SpaceshipMovement : MonoBehaviour
{
    public float shipSpeed;
    float horizontalVelocity;
    Vector2 tempVelocity;
    	
	// Update is called once per frame
	void Update ()
    {
        // store the ships horizontal input axis
        horizontalVelocity = Input.GetAxisRaw("Horizontal");

        // calculate the velocity of the ship based on the horizontal input 
        tempVelocity = new Vector2(horizontalVelocity * shipSpeed, 0);
        tempVelocity.Normalize();
        tempVelocity *= shipSpeed;

        // apply the velocity to the ships rigid body
        GetComponent<Rigidbody2D>().velocity = tempVelocity;	
	}
}
