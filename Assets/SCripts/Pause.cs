using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public bool isPaused = false;
   
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            pauseGame();
        } 
    }

    void pauseGame()
    {
        if(isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else if(isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }

}
