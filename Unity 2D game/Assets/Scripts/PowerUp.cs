using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Movement.horizontalSpeed = 4f;

            Jump.jumpman = new Vector2(0, 600);

            levelManager.score++;

            Destroy(gameObject);
        }




    }
}