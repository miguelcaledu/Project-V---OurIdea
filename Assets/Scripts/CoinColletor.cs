using UnityEngine;

public class Coin : MonoBehaviour
{
    private int value = 1; // Value of the coin

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player collected the coin
        {
            GameManager.instance.AddCoins(value); // Update the coin count in the GameManager
            Destroy(gameObject); // Remove the coin from the scene
        }
    }
}
