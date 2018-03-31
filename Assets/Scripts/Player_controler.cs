﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour {

    public Rigidbody2D rb;
    public Vector2 forceY = new Vector2(0, 0);//сила прыжка
    public Vector2 forceX = new Vector2(0, 0);//сила ходьбы!!!

    private bool isJump = false;
    private short k = 0; //doublejump

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isJump == false)
        {
            rb.AddForce(forceY);
            k++;
            if(k >= 2)
              isJump = true;
        }
        /*if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(-forceY);
        }*/
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(forceX);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-forceX);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isJump = false;
        k = 0;
    }
}
