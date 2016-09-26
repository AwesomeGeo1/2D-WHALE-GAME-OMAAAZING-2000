using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laserkittenenimiescript : MonoBehaviour {
    public float movementSpeed = 10;
    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }


    }
    // Update is called once per frame
    void Update () {
        move();
    
    }
    void move()
    {
        transform.Translate(Vector3.left * Time.deltaTime);

        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
