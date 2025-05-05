using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.coinCount++;
            Debug.Log("����­�������: " + CoinManager.coinCount);
            Destroy(gameObject); // ź����­����ͪ� Player
        }
    }
}
