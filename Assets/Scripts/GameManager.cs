using UnityEngine;
using TMPro; // For TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    private int coinCount = 0; // Tracks the player's total coins


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
    }

    /// <summary>
    /// 
    /// </summary>


    public int GetCoinCount()
    {
        return coinCount;
    }
}
