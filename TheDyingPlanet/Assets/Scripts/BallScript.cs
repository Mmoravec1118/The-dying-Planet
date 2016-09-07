using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Block")
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100));
        }
    }
}
