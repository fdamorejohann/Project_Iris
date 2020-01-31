using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaforboss : MonoBehaviour

{

    [SerializeField]
    private Boss1 bigb;

    float health;
    float timer;

    public Collider2D lava1;

    public Collider2D lava2;
    // Start is called before the first frame update
    void Start()
    {

        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > -10)
        { 
        timer += Time.deltaTime;

        if (timer > 3.5)
            Destroy(gameObject);

    }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            bigb.health = 0;
            bigb.reset = true;
             bigb.timer1 = 0;
}

        if (collision.collider.tag == "END")
        {
            Destroy(gameObject);
        }




    }


}
