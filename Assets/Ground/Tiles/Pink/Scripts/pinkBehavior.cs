using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkBehavior : MonoBehaviour
{

    private Vector2 firstPosition;
    private Vector2 originalPosition;
    private Vector2 targetPosition;
    private Vector2 currentPosition;
    private float maxDistance;
    private Vector2 movement;
    private Rigidbody2D rb = null;
    public Vector2 secondPosition;
    public float speed = 1.0f;
    public Phases phase;
    private Material color;

    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        firstPosition = transform.position;
        maxDistance = Vector2.Distance(firstPosition, secondPosition);

    }

    // Update is called once per frame
    void Update()
    {

        // Get the current position
        currentPosition = transform.position;

        if (phase.currentPhase)
        {
            originalPosition = firstPosition;
            targetPosition = secondPosition;
            gameObject.GetComponent<Renderer>().material.color = Color.gray;
            
        }
        else
        {

            originalPosition = secondPosition;
            targetPosition = firstPosition;
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;

        }

        if(currentPosition != targetPosition)
        {

            movement = new Vector2(targetPosition.x - currentPosition.x, targetPosition.y - currentPosition.y) * 1/speed;
            rb.velocity = movement;

        }

        if (Vector2.Distance(currentPosition, originalPosition) >= maxDistance) currentPosition = targetPosition;

    }
}
