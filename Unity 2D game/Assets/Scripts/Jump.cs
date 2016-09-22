using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{

    public Rigidbody2D rb;
    Vector2 jumpman = new Vector2(0, 500);

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            rb.AddForce(jumpman);
        }
    }
}