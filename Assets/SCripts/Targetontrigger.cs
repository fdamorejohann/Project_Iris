﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetontrigger : MonoBehaviour
{ 
    public GameObject Player;

    [SerializeField]
    private Transform startzone;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Death")
        {
            Player.GetComponent<Transform>().position = startzone.position;
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        if (collision.collider.tag == "Player")
        {
            Player.GetComponent<Transform>().position = startzone.position;
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }
}

