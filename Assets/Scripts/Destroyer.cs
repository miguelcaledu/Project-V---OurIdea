using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // This method is called when another object enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is tagged as "Player" (or any other relevant tag)
        if (other.CompareTag("Player"))
        {
            // Destroy the arrow GameObject
            Destroy(gameObject);
        }
    }
}

