using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.HasKey("level0 First") == false)
        {
            PlayerPrefs.SetInt("level0 First", 0);
        }
        if (PlayerPrefs.HasKey("level1 First") == false)
        {
            PlayerPrefs.SetInt("level1 First", 0);
        }
        if (PlayerPrefs.HasKey("level2 First") == false)
        {
            PlayerPrefs.SetInt("level2 First", 0);
        }
        if (PlayerPrefs.HasKey("level3 First") == false)
        {
            PlayerPrefs.SetInt("level3 First", 0);
        }
        if (PlayerPrefs.HasKey("level4 First") == false)
        {
            PlayerPrefs.SetInt("level4 First", 0);
        }
        if (PlayerPrefs.HasKey("level5 First") == false)
        {
            PlayerPrefs.SetInt("level5 First", 0);
        }
        if (PlayerPrefs.HasKey("level6 First") == false)
        {
            PlayerPrefs.SetInt("level6 First", 0);
        }

        if (PlayerPrefs.HasKey("level1 Jump") == false)
        {
            PlayerPrefs.SetInt("level1 Jump", 0);
        }
        if (PlayerPrefs.HasKey("level2 Jump") == false)
        {
            PlayerPrefs.SetInt("level2 Jump", 0);
        }
        if (PlayerPrefs.HasKey("level3 Jump") == false)
        {
            PlayerPrefs.SetInt("level3 Jump", 0);
        }
        if (PlayerPrefs.HasKey("level4 Jump") == false)
        {
            PlayerPrefs.SetInt("level4 Jump", 0);
        }
        if (PlayerPrefs.HasKey("level5 Jump") == false)
        {
            PlayerPrefs.SetInt("level5 Jump", 0);
        }
        if (PlayerPrefs.HasKey("level6 Jump") == false)
        {
            PlayerPrefs.SetInt("level6 Jump", 0);
        }

        if (PlayerPrefs.HasKey("level1 Death") == false)
        {
            PlayerPrefs.SetInt("level1 Death", 0);
        }
        if (PlayerPrefs.HasKey("level2 Death") == false)
        {
            PlayerPrefs.SetInt("level2 Death", 0);
        }
        if (PlayerPrefs.HasKey("level3 Death") == false)
        {
            PlayerPrefs.SetInt("level3 Death", 0);
        }
        if (PlayerPrefs.HasKey("level4 Death") == false)
        {
            PlayerPrefs.SetInt("level4 Death", 0);
        }
        if (PlayerPrefs.HasKey("level5 Death") == false)
        {
            PlayerPrefs.SetInt("level5 Death", 0);
        }
        if (PlayerPrefs.HasKey("level6 Death") == false)
        {
            PlayerPrefs.SetInt("level6 Death", 0);
        }

        if (PlayerPrefs.HasKey("level1 temp") == false)
        {
            PlayerPrefs.SetInt("level1 temp", 0);
        }

        if (PlayerPrefs.HasKey("level2 temp") == false)
        {
            PlayerPrefs.SetInt("level2 temp", 0);
        }
        if (PlayerPrefs.HasKey("level3 temp") == false)
        {
            PlayerPrefs.SetInt("level3 temp", 0);
        }
        if (PlayerPrefs.HasKey("level3 temp") == false)
        {
            PlayerPrefs.SetInt("level3 temp", 0);
        }
        if (PlayerPrefs.HasKey("level4 temp") == false)
        {
            PlayerPrefs.SetInt("level4 temp", 0);
        }
        if (PlayerPrefs.HasKey("level5 temp") == false)
        {
            PlayerPrefs.SetInt("level5 temp", 0);
        }

        if (PlayerPrefs.HasKey("level6 temp") == false)

        {
            PlayerPrefs.SetInt("level6 temp", 0);
        }



    }
}
