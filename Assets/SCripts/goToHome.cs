using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToHome : MonoBehaviour
{
    public Pause pausescript;
    public bool begining;

    public bool p;
    private void Update()
    {

        if (p == false)
        {
            if (pausescript.isPaused == false)
            {
                gameObject.SetActive(false);
            }
        }


    }


    public void Home()
    {
        if(begining == true)
        {
            SceneManager.LoadScene(1);
        }
        else
            SceneManager.LoadScene(2);
    }
}
