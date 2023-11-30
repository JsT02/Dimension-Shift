using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public playerLives lives;

    // Update is called once per frame
    void Update()
    {

        if (lives.isAlive == false) Debug.Log("Game over");

    }
}
