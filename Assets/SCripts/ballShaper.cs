using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShaper : MonoBehaviour
{
    [SerializeField]
    private NewBehaviourScript playerscript;

    [SerializeField]
    private Transform player;



    [SerializeField]
    private Transform camera;

    public bool ball2;

    public bool isfollowing;

    public float newx;
    public float newy;

    // Start is called before the first frame update
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {


        if (isfollowing == true)
        {
            transform.position = new Vector3(player.position.x + newx, newy, -9);
        }
        else
        {
            transform.position = new Vector3(newx, newy, -9);
        }


        if (playerscript.isGrounded == true)
        {
            if (ball2 == false)
            {
                //  transform.position = transform.position = new Vector3(ball.position.x, ball.position.y, 0);
                GetComponent<Renderer>().material.color = new Color(0, 255, 255); //C sharp
            }
        }

        if (playerscript.isGrounded == false)
        {
            if (ball2 == false)
            {
                //transform.position = transform.position = new Vector3(ball.position.x, ball.position.y, 2);
                GetComponent<Renderer>().material.color = new Color(0, 0, 255); //C sharp
            }

        }
            if (playerscript.doubleJump == false)
            {
                if (ball2 == true)
                {
                    GetComponent<Renderer>().material.color = new Color(0, 255, 255); //C sharp
                }
            }
            if (playerscript.doubleJump == true)
            {
                if (ball2 == true)
                {
                    GetComponent<Renderer>().material.color = new Color(0, 0, 255); //C sharp
                }
            }


   
    }
}


