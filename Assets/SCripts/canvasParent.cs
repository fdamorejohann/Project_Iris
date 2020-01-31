using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasParent : MonoBehaviour
{

    public Pause pausescript;
    public GameObject homeButton;

    public bool homeScreen;
    public bool homeScreen2;

    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lvl5;
    public GameObject lvl6;


    // Start is called before the first frame update
    void Start()
    {
        if(homeScreen == true)
        {
            displayThem();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (homeScreen2 == false)
        {
            if (pausescript.isPaused == true)
            {
                homeButton.SetActive(true);
            }
        }
    }


private void displayThem()
    {
        if (PlayerPrefs.GetInt("level0 First") != 0)
        {
            lvl1.SetActive(true);
        }
        else
            lvl1.SetActive(false);

        if (PlayerPrefs.GetInt("level1 First") != 0)
        {
            lvl2.SetActive(true);
        }
        else
            lvl2.SetActive(false);

        if (PlayerPrefs.GetInt("level2 First") != 0)
        {
            lvl3.SetActive(true);
        }
        else
            lvl3.SetActive(false);

        if (PlayerPrefs.GetInt("level3 First") != 0)
        {
            lvl4.SetActive(true);
        }
        else
            lvl4.SetActive(false);

        if (PlayerPrefs.GetInt("level4 First") != 0)
        {
            lvl5.SetActive(true);
        }
        else
            lvl5.SetActive(false);

        if (PlayerPrefs.GetInt("level5 First") != 0)
        {
            lvl6.SetActive(true);
        }
        else
            lvl6.SetActive(false);

    }
}
