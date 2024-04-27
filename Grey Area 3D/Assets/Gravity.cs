using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
     public Rigidbody rb;
    public float gravityScale = 2f; 
    public float terminalVelocity = 10f; 

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {
        
        Vector3 gravity = gravityScale * Physics.gravity;
        rb.AddForce(gravity, ForceMode.Acceleration);

        
        float verticalVelocity = Mathf.Clamp(rb.velocity.y, -terminalVelocity, Mathf.Infinity);
        rb.velocity = new Vector3(rb.velocity.x, verticalVelocity, rb.velocity.z);
    }
}
