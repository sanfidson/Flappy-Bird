﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Column : MonoBehaviour
{
    public GameObject bird;
    private int run;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (bird)
        {
            run = 1;
        } else 
        {
            run = 0;
        }
        transform.Translate((Vector2.left * speed * Time.deltaTime)*run);
    }
}
