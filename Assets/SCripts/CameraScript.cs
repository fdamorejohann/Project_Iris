using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    private Vector3 target;
    [SerializeField]
    public GameObject cursor;

    public float changeCameraSize;
    public float newCameraSize;

    public float follow;
    public float height;
    public float dis;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        cursor.transform.position = new Vector2(target.x, target.y);

        if (follow == 0)
        {
            transform.position = new Vector3(player.position.x + dis, 10 + height, -10);
        }// Camera follows the player but 6 to the right

        else if (follow == 1)
        {
            transform.position = new Vector3(player.position.x + dis, height + player.position.y, -10);
        }

        else if (follow == -1)
        {
            transform.position = new Vector3(dis, height, -10);
        }

        if (changeCameraSize > 0)
        {
            Camera.main.orthographicSize = newCameraSize;
        }
    }
}
