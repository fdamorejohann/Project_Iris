using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{


    [SerializeField]
    private Transform bTip;

    public bool killmusic;

    [SerializeField]
    private Pause pauseFeature;

    [SerializeField]
    private Transform qTip;

    [SerializeField]
    private Transform cursor;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform startzone;

    public GameObject Player;

    private Vector2 LookDirection;
    private float LookAngle;

    public bool isGrounded;

    public bool doubleJump;

    private float timer;

    public float glitchCheck;

    public bool hardcore;

    public float level;

    public int jump;

    public int deaths;
    public int ya;
    public int yaya;






    // Start is called before the first frame update
    void Start()
    {
        killmusic = false;
        jump = 0;
        startDeath();

    }

    // Update is called once per frame
    void Update()
    {

        timer = timer + Time.deltaTime;

        if (Player.GetComponent<Rigidbody2D>().velocity.x == 0)
        {
            glitchCheck = Time.deltaTime;
        }

        if (Player.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            glitchCheck = 0;
        }

        if (glitchCheck > .017)
        {
            isGrounded = true;
            doubleJump = false;
            glitchCheck = 0;
        }



        LookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        LookAngle = Mathf.Atan2(LookDirection.y, LookDirection.x) * Mathf.Rad2Deg;
        qTip.transform.rotation = Quaternion.Euler(0f, 0f, LookAngle - 90f);



        if (Input.GetMouseButtonDown(0))
        {
            if (pauseFeature.isPaused == false)
            {
                if (isGrounded == true || doubleJump == false)
                {
                    jump = jump + 1;
                    Jump();
                }
            }
        }

        if (timer > .2)
        {

            // FireBullet();
            timer = 0;
        }


        if (Input.GetButtonDown("Fire1"))
        {
            setTemps();
        }





    }

    private void Jump()
    {
        if (doubleJump == false && isGrounded == true)
        {
            isGrounded = false;
            Player.GetComponent<Rigidbody2D>().velocity = bTip.up * 25;
        }

        else if (doubleJump == true && isGrounded == true)
        {
            isGrounded = false;
            Player.GetComponent<Rigidbody2D>().velocity = bTip.up * 25;
        }

        else if (doubleJump == false && isGrounded == false)
        {
            doubleJump = true;
            Player.GetComponent<Rigidbody2D>().velocity = bTip.up * 20;
        }

    }

    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, bTip.position, bTip.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = bTip.up * 25f;
    }







    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
            //Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            doubleJump = false;
        }

        if (collision.collider.tag == "Death")
        {
            if (hardcore == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }

            Player.GetComponent<Transform>().position = startzone.position;
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            jump = 0;
            addDeath();
        }

        if (collision.collider.tag == "END")
        {
            Player.GetComponent<Transform>().position = startzone.position;
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }

        if (collision.collider.tag == "reJump")
        {
            doubleJump = false;
            isGrounded = true;
        }

        if (collision.collider.tag == "new")
        {

            FinalJump();
            FinalDeaths();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }





    private void tig()
    {
        ya = PlayerPrefs.GetInt("level2 Jump");
        yaya = PlayerPrefs.GetInt("level2 First");
    }













    private void setTemps()
    {
        if (level == 1)
        {
            PlayerPrefs.SetInt("Level1 temp", deaths);

        }
        else if (level == 2)
        {
            PlayerPrefs.SetInt("Level2 temp", deaths);

        }
        else if (level == 3)
        {
            PlayerPrefs.SetInt("Level3 temp", deaths);

        }
        else if (level == 4)
        {
            PlayerPrefs.SetInt("Level4 temp", deaths);

        }
        else if (level == 5)
        {
            PlayerPrefs.SetInt("Level5 temp", deaths);

        }
        else if (level == 6)
        {
            PlayerPrefs.SetInt("Level6 temp", deaths);

        }

    }






    private void startDeath()
    {
        if(level == 1)
        {
            deaths = PlayerPrefs.GetInt("Level1 temp");

        }
        else if (level == 2)
        {
            deaths = PlayerPrefs.GetInt("Level2 temp");

        }
        else if (level == 3)
        {
            deaths = PlayerPrefs.GetInt("Level3 temp");

        }
        else if (level == 4)
        {
            deaths = PlayerPrefs.GetInt("Level4 temp");

        }
        else if (level == 5)
        {
            deaths = PlayerPrefs.GetInt("Leve5 temp");

        }
        else if (level == 6)
        {
            deaths = PlayerPrefs.GetInt("Level6 temp");

        }
    }



    private void addDeath()
    {
        deaths = deaths + 1;
        if (level == 1)
        {
            PlayerPrefs.SetInt("level1 temp", deaths);

        }
        else if (level == 2)
        {
            PlayerPrefs.SetInt("level2 temp", deaths);

        }
        else if (level == 3)
        {
            PlayerPrefs.SetInt("level3 temp", deaths);

        }
        else if (level == 4)
        {
            PlayerPrefs.SetInt("level4 temp", deaths);

        }
        else if (level == 5)
        {
            PlayerPrefs.SetInt("level5 temp", deaths);

        }
        else if (level == 6)
        {
            PlayerPrefs.SetInt("level6 temp", deaths);
        }

    }

    private void FinalDeaths()
    {
        if(level == 0)
        {
            PlayerPrefs.SetInt("level0 First", 1);
        }

        else if (level == 1)
        {
            if (PlayerPrefs.GetInt("level1 Death") > deaths  || PlayerPrefs.GetInt("level1 First") == 0)
            {
                PlayerPrefs.SetInt("level1 Death", deaths);
                PlayerPrefs.SetInt("level1 First", 1);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level1 temp", 0);

        }
        else if (level == 2)
        {
            if (PlayerPrefs.GetInt("level2 Death") > deaths || PlayerPrefs.GetInt("level2 First") == 0)
            {
                PlayerPrefs.SetInt("level2 Death", deaths);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level2 temp", 0);
            PlayerPrefs.SetInt("level2 First", 1);

        }
        else if (level == 3)
        {
            if (PlayerPrefs.GetInt("level3 Death") > deaths || PlayerPrefs.GetInt("level3 First") == 0)
            {
                PlayerPrefs.SetInt("level3 Death", deaths);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level3 temp", 0);
            PlayerPrefs.SetInt("level3 First", 2);
        }
        else if (level == 4)
        {
            if (PlayerPrefs.GetInt("level4 Death") > deaths || PlayerPrefs.GetInt("level4 First") == 0)
            {
                PlayerPrefs.SetInt("level4 Death", deaths);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level4 temp", 0);
            PlayerPrefs.SetInt("level4 First", 2);

        }
        else if (level == 5)
        {
            if (PlayerPrefs.GetInt("level5 Death") > deaths || PlayerPrefs.GetInt("level5 First") == 0)
            {
                PlayerPrefs.SetInt("level5 Death", deaths);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level5 temp", 0);
            PlayerPrefs.SetInt("level5 First", 2);
        }
        else if (level == 6)
        {
            if (PlayerPrefs.GetInt("level6 Death") > deaths || PlayerPrefs.GetInt("level6 First") == 0)
            {
                PlayerPrefs.SetInt("level6 Death", deaths);
            }
            deaths = 0;
            PlayerPrefs.SetInt("level6 temp", 0);
            PlayerPrefs.SetInt("level6 First", 2);
        }
    }






    private void FinalJump()
    {
        if (level == 1)
        {
            if(PlayerPrefs.GetInt("level1 Jump") >jump || PlayerPrefs.GetInt("level1 Jump") == 0)
            {
                PlayerPrefs.SetInt("level1 Jump", jump);
            }
        
        }
        else if (level == 2)
        {
            if (PlayerPrefs.GetInt("level2 Jump") > jump || PlayerPrefs.GetInt("level2 Jump") == 0)
            {
                PlayerPrefs.SetInt("level2 Jump", jump);
            }
          
        }
        else if (level == 3)
        {
            if (PlayerPrefs.GetInt("level3 Jump") > jump || PlayerPrefs.GetInt("level3 Jump") == 0)
            {
                PlayerPrefs.SetInt("level3 Jump", jump);
            }
           
        }
        else if (level == 4)
        {
            if (PlayerPrefs.GetInt("level4 Jump") > jump || PlayerPrefs.GetInt("level4 Jump") == 0)
            {
                PlayerPrefs.SetInt("level4 Jump", jump);
            }
           
        }
        else if (level == 5)
        {
            if (PlayerPrefs.GetInt("level5 Jump") > jump || PlayerPrefs.GetInt("level5 Jump") == 0)
            {
                PlayerPrefs.SetInt("level5 Jump", jump);
            }
           
        }
        else if (level == 6)
        {
            if (PlayerPrefs.GetInt("level6 Jump") > jump || PlayerPrefs.GetInt("level6 Jump") == 0)
            {
                PlayerPrefs.SetInt("level6 Jump", jump);
            }
           
        }
    }
}
