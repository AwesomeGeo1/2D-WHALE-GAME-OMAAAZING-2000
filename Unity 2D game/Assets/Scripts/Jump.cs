using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{

    public Rigidbody2D rb;
    public static Vector2 jumpman = new Vector2(0, 500);
    public bool jumpenabled;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        jumpenabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (jumpenabled == true)
        {
            if (Input.GetButtonUp("Jump"))
            {
                rb.AddForce(jumpman);
                jumpenabled = false;
            }


        }

    }
}