using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotScript : MonoBehaviour
{
    public Transform movement;
    public float valuex;
    public float valuey;

 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            movement.transform.position = new Vector3(movement.position.x - valuex, movement.position.y - valuey, 0);
        }

    }


}
