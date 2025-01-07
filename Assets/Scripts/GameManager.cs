using UnityEngine;
using TMPro; // For TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    private int coinCount = 0; // Tracks the player's total coins

    public TextMeshProUGUI coinText; // Reference to the TextMeshPro UI element

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount)
    {
        coinCount += amount; // Increase the coin count
        UpdateCoinUI(); // Update the UI
    }

    private void UpdateCoinUI()
    {
        coinText.text = "KILT'S: " + coinCount; // Update the text to show the current coin count
    }

    public int GetCoinCount()
    {
        return coinCount;
    }
}
