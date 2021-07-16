using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb = null;
    public float forwardForce = 2000f;
    public float sidewaysFroce = 500f;

    // FixedUpdate is called once per frame and we change it to 
    //Fixed to not mess with the physics we are using
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysFroce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysFroce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
