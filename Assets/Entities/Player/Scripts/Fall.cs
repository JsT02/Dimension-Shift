using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{
    public playerLives lives;
    public GameObject Player;
    private Vector2 SpawnPoint;

    private void Start()
    {
        SpawnPoint = Player.transform.position;
    }
    private void Update()
    {

        if (Player.transform.position.y < -20)
        {

            Player.transform.position = SpawnPoint;
            lives.takeDamage = true;

        }

    }

}
