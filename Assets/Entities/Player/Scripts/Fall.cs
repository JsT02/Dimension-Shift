using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{

    public GameObject Player;
    public TextMeshProUGUI lifecounter;
    private int LivesLeft;
    private Vector2 SpawnPoint;

    private void Start()
    {
        LivesLeft = 3;
        SpawnPoint = Player.transform.position;
    }
    private void Update()
    {

        if (Player.transform.position.y < -20)
        {

            Player.transform.position = SpawnPoint;

            LivesLeft--;

        }

        lifecounter.text = new string("Lives: " + LivesLeft);

        if(LivesLeft == -1)
        {

            Debug.Log("Player has died");

        }

    }

}
