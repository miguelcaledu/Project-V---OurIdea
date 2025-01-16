using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int value = 1; // Value of the coin

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player collected the coin
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.AddCoins(value); // Update the coin count in the GameManager
            }
            else
            {
                Debug.LogError("GameManager.instance is null!");
            }
            Destroy(gameObject); // Remove the coin from the scene
        }
    }
}
