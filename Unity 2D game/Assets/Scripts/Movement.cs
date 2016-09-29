using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D rb;
    //move forwards and move backwards as vectors with 2 perameters.
    public static float horizontalSpeed;
    // Use this for initialization
    void Start () {

        horizontalSpeed = 3;
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
