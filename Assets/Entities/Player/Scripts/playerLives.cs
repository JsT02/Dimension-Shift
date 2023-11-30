using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerLives : MonoBehaviour
{
    public GameObject player;
    public int maxLives = 5;
    private int currentLives;
    public bool takeDamage;
    public bool isAlive = false;
    public TextMeshProUGUI lifetext;

    private void Awake()
    {

        currentLives = maxLives;
        isAlive = true;

    }

    private void Update()
    {

        if (takeDamage)
        {

            currentLives--;
            takeDamage = false;

        }

        if (currentLives <= 0)
        {

            isAlive = false;
            currentLives = 0;

        }

        lifetext.text = new string("Lifes: " + currentLives);

    }

}
