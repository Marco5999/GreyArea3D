using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 startPosition; // Start position of the player

    void Start()
    {
        // Store the player's start position
        startPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider that collided with the player is tagged as "Trap"
        if (collision.collider.CompareTag("Trap"))
        {
            // Respawn the player at the start position
            transform.position = startPosition;
        }
    }
}
