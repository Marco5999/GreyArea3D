using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
   public AudioClip coinSound; 
    private AudioSource audioSource; 

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Coin"))
        {
            
            Destroy(collision.gameObject);

           
            if (coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }
        }
    }
}
