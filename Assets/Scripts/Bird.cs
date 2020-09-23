﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed; 
    Rigidbody2D rb;
    
    
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //flap effect
            rb.velocity = Vector2.up * speed;
        }
    }
}
