using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D rb;
    //move forwards and move backwards as vectors with 2 perameters.
    Vector2 moveForwards = new Vector2(100, 0);
    Vector2 moveBackwards = new Vector2(-100, 0);
    private float horizontalSpeed = 3F;
    // Use this for initialization
    void Start () {
        //gets rigidBody
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        float h = horizontalSpeed * Input.GetAxis("Horizontal");


        //applies moveForward to the force being added
        Vector2 movement = new Vector2(h, 0);

        rb.AddForce(movement * horizontalSpeed);  
	}
}
