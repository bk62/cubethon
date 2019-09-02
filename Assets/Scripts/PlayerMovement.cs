using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;

    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

// TODO getaxis
// dont check input in fixed update when jumping etc
// check in input and set force here
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // fell off?
        if (rb.position.y < -.5f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
