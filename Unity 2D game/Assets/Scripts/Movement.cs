using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D ridgidBody;
    //move forwards and move backwards as vectors with 2 perameters.
    Vector2 moveForwards = new Vector2(100, 0);
    Vector2 moveBackwards = new Vector2(-100, 0);
	// Use this for initialization
	void Start () {
        //gets rigidBody
        ridgidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //checks to see if the right arrow key is being pressed
        if (Input.GetButtonUp("Horizontal"))
        {
            //applies moveForward to the force being added
            ridgidBody.AddForce(moveForwards);
        }
        //checks and sees if the left arrow key is being pressed yes I know vertical is up and down not backwards, but it was not working in horizontal, so I improvised
        if (Input.GetButtonUp("Vertical"))
        {
            //applies the vector2 moveBackwards to the force being added
            ridgidBody.AddForce(moveBackwards);
        }
        
	}
}
