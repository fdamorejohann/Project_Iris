using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseLevel : MonoBehaviour
{

    public int level;
    // Start is called before the first frame update



    public void chosenLevel()
    {
        SceneManager.LoadScene(level + 3);
    }

}
