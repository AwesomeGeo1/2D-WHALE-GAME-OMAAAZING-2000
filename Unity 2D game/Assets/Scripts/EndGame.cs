using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
    public bool levelComplete = false;
    public Rigidbody2D rigidBody;
    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        levelComplete = false;
      
    }

    // Update is called once per frame
    void Update() {
       
        }


    void OnTriggerEnter2D(Collider2D other)
        {
        if (levelComplete == false)
        {
            levelComplete = true;
            
        }
        
       
        }
        }
    
