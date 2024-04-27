using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public float moveSpeed = 5f; 
    public float jumpForce = 8f; 
    public Transform groundCheck; 
    public string groundTag = "Ground"; 

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f) && IsGroundWithTag();

        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
        }
    }

    bool IsGroundWithTag()
    {
        Collider[] colliders = Physics.OverlapSphere(groundCheck.position, 0.1f);
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(groundTag))
            {
                return true;
            }
        }
        return false;
    }
}
