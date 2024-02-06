using UnityEngine;
using System.Collections;
using TMPro;
using UnityEditor.UI;
public class Pacer : MonoBehaviour
{

    public float speed = 5.0f;
    private float zMax = 7.5f;

    private float zMin = -7.5f; //starting position
    private int direction = 1; //positive to start

    void Update()
    {
        float zNew = transform.position.z +
        direction* speed *Time.deltaTime;
        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
         }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
         }
        transform.position = new Vector3(transform.position.x, transform.position.y, zNew);
    }

    // void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log("in projectile");
    //     if (other.gameObject.CompareTag("projectile")){
    //         Debug.Log("Hit projectile");
    //         GetComponent("pickupParent").GetComponent<ScoreboardManager>().AddScore();
    //         // GetComponentInParent<ScoreboardManager>().AddScore();
    //         gameObject.SetActive(false);
    //     }
    // }
}
