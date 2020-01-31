using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extraJump : MonoBehaviour
{

    [SerializeField]
    private NewBehaviourScript p1;

    private float startx;
    private float starty;
    private float startz;
    private float timer;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        startx = GetComponent<Transform>().position.x;
        starty = GetComponent<Transform>().position.x;
        startz = GetComponent<Transform>().position.x;
        GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > 2)
        {
            if(triggered == true)
            {
                GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp
                timer = 0;
                triggered = false;
            }
            else if (triggered == false)
            {
                timer = 0;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(triggered == false)
            {
                p1.isGrounded = true;
                p1.doubleJump = false;
                triggered = true;
                GetComponent<Renderer>().material.color = new Color(0, 0, 255); //C sharp
                timer = 0;
            }
        }

    }


}