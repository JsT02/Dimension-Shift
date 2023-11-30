using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class harmfulBehavior : MonoBehaviour
{
    public playerLives lives;
    private bool harmful = false;
    public Phases phase;
    private Material color;

    // Update is called once per frame
    void Update()
    {

        if (phase.currentPhase)
        {

            harmful = true;
             gameObject.GetComponent<Renderer>().material.color = Color.cyan;

        }
        else
        {

            harmful = false;
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") && harmful) lives.takeDamage = true;
        Debug.Log("Entered collision with harmful tile");

    }
}
