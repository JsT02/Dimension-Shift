using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenBehavior : MonoBehaviour
{
    
    private Vector2 position1;
    public Vector2 position2;
    public Phases phase;
    private Material color;

    private void Awake()
    {

        position1 = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (phase.currentPhase)
        {

            transform.position = position2;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {

            transform.position = position1;
            gameObject.GetComponent<Renderer>().material.color = Color.green;

        }
    }
}
