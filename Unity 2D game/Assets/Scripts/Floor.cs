using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    public Jump istojump;

    // Use this for initialization
    void Start () {

        GameObject thePlayer = GameObject.Find("Wessessesesses awesome whaleeeeee of a time");
        Jump g = thePlayer.GetComponent<Jump>();

        istojump = g.GetComponent<Jump>();
    }
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player")
        {
            istojump.jumpenabled = true;
        }

	}
}
