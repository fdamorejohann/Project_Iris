using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour
{


    [SerializeField]
    private CameraScript mainCamera;

    [SerializeField]
    private ballShaper balls;

    [SerializeField]
    private ballShaper balls1;

    [SerializeField]
    private float bcC;

    [SerializeField]
    private float bcD;

    public bool changeballs;

    public bool stopFollowing;


    [SerializeField]
    private float ChangeSize;

    [SerializeField]
    private float NewSize;

    [SerializeField]
    private float cC;

    [SerializeField]
    private float cD;

    [SerializeField]
    private float following;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            mainCamera.height = cC;
            mainCamera.dis = cD;

            if (following == 1)
            {
                mainCamera.follow = 1;
            }

            else if (following == 0)
                mainCamera.follow = 0;
            else if (following == -1)
                mainCamera.follow = -1;

            if (ChangeSize > 0)
            {
                mainCamera.changeCameraSize = 1;
                mainCamera.newCameraSize = NewSize;

            }

            if (changeballs == true)
            {
                balls.newx = bcC;
                balls.newy = bcD;
                balls1.newx = bcC - 3;
                balls1.newy = bcD;

                if (stopFollowing == true)
                {
                    balls.isfollowing = false;
                    balls1.isfollowing = false;
                }
                else
                {
                    balls.isfollowing = true;
                    balls1.isfollowing = true;
                }

            }


        }
    }


}
