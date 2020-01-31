using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour
{
    static dontDestroy instance = null;

    public NewBehaviourScript player;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }


        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

        // Update is called once per frame
        void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex >= 4)
        {
            Destroy(gameObject);
        }

        AudioListener.volume = 1f;
    }
}
