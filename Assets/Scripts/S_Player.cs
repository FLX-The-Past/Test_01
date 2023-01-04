using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Player : MonoBehaviour
{
    public float Speed;

    public Rigidbody2D rb;
    
    void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

   void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
        }
    }
}
