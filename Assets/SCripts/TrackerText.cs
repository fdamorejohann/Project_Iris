using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackerText : MonoBehaviour
{

    public Text level1D;
    public Text level1J;

    public Text level2D;
    public Text level2J;

    public Text level3D;
    public Text level3J;

    public Text level4D;
    public Text level4J;

    public Text level5D;
    public Text level5J;

    public Text level6D;
    public Text level6J;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("level1 First") != 0)
        {
            level1D.text = "Deaths: " + PlayerPrefs.GetInt("level1 Death");
            level1J.text = "Jumps: " + PlayerPrefs.GetInt("level1 Jump");
        }

        if (PlayerPrefs.GetInt("level2 First") != 0)
        {
            level2D.text = "Deaths: " + PlayerPrefs.GetInt("level2 Death");
            level2J.text = "Jumps: " + PlayerPrefs.GetInt("level2 Jump");
        }

        if (PlayerPrefs.GetInt("level3 First") != 0)
        {
            level3D.text = "Deaths: " + PlayerPrefs.GetInt("level3 Death");
            level3J.text = "Jumps: " + PlayerPrefs.GetInt("level3 Jump");
        }

        if (PlayerPrefs.GetInt("level4 First") != 0)
        {
            level4D.text = "Deaths: " + PlayerPrefs.GetInt("level4 Death");
            level4J.text = "Jumps: " + PlayerPrefs.GetInt("level4 Jump");
        }

        if (PlayerPrefs.GetInt("level5 First") != 0)
        {
            level5D.text = "Deaths: " + PlayerPrefs.GetInt("level5 Death");
            level5J.text = "Jumps: " + PlayerPrefs.GetInt("level5 Jump");
        }

        if (PlayerPrefs.GetInt("level6 First") != 0)
        {
            level6D.text = "Deaths: " + PlayerPrefs.GetInt("level6 Death");
            level6J.text = "Jumps: " + PlayerPrefs.GetInt("level6 Jump");
        }












    }
}
