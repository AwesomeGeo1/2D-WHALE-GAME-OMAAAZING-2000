using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D ridgidBody;

    Vector2 moveForwards = new Vector2(100, 0);

	// Use this for initialization
	void Start () {
        ridgidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Horizontal"))
        {
            ridgidBody.AddForce(moveForwards);
        }
	}
}
