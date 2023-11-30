using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public TextMeshProUGUI CoinCounter;
    private int CoinsCollected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {

            Destroy(collision.gameObject);
            CoinsCollected++;
            CoinCounter.text = new string("Coins: " + CoinsCollected);
            

        }
    }
}
