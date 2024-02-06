using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMover : MonoBehaviour
{
    public bool zDirection = true;
    public float speed = 3.0f;
    private float posMax = 7.5f;

    private float posMin = -7.5f; //starting position
    private int direction = 1; //positive to start

    void Update()
    {
        if(zDirection){
            float zNew = transform.position.z +
            direction* speed *Time.deltaTime;
            if (zNew >= posMax)
            {
                zNew = posMax;
                direction *= -1;
            }
            else if (zNew <= posMin)
            {
                zNew = posMin;
                direction *= -1;
            }

            transform.position = new Vector3(transform.position.x, transform.position.y, zNew);
        } else {
            float xNew = transform.position.x +
            direction* speed *Time.deltaTime;
            if (xNew >= posMax)
            {
                xNew = posMax;
                direction *= -1;
            }
            else if (xNew <= posMin)
            {
                xNew = posMin;
                direction *= -1;
            }

            transform.position = new Vector3(xNew, transform.position.y, transform.position.z);
        }
    }
}
