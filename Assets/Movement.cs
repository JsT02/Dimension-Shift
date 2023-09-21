using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W)) { transform.Translate(Vector2.up * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(Vector2.left * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(Vector2.right * speed * Time.deltaTime); }

    }
}