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

}