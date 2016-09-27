using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laserkittenenimiescript : MonoBehaviour {

    private float delta = 10f;  // Amount to move left and right from the start point
    private float speed = 2.0f; // Speed at which the character moves
    private Vector3 startPos;
    // Use this for initialization
    void Start () {
        startPos = transform.position;
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
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
