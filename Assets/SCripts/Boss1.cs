using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss1 : MonoBehaviour
{

    public float health;
    public float timer = 0;
    public float timer1 = 0;

    // public Text textbox;

    [SerializeField]
    private GameObject lava;


    public Transform[] valuesHorizontal;

    public Transform[] valuesVertical;

    private int choice1;
    private int choice2;

    private int variable;

    public float damage;

    public bool reset;
    public float speed;


    // Start is called before the first frame update

    void Start()
    {
       damage = 2;
     //   textbox = GetComponent<Text>();
    } // Update is called once per frame
    void Update()
    {

        if (health < 10)
        {
            damage = 2;
    

        }
        else if (health < 20)
        {
            damage = 2;
        }


//    

        if (reset == true)
        {
            transform.position = new Vector3(66, 12, 0);
            reset = false;
        }

      
        timer += Time.deltaTime;
        timer1 += Time.deltaTime;

        if (timer > damage)
        {

            choice1 = Random.Range(0, 3);
            choice2 = Random.Range(0, 3);
            Spawn();
            timer = 0;
        }

        if (health > 40)
        {
            Destroy(gameObject);
        }

    
    }


    void Spawn()
    {


        GameObject firedBullet = Instantiate(lava, valuesHorizontal[choice1].position, valuesHorizontal[choice1].rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = valuesHorizontal[choice1].up * 20f;

        GameObject firedBullet2 = Instantiate(lava, valuesVertical[choice2].position, valuesVertical[choice2].rotation);
        firedBullet2.GetComponent<Rigidbody2D>().velocity = valuesVertical[choice2].up * 20f;



    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            health += 1;
        }

    }

}