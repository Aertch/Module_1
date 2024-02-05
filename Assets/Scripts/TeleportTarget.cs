using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTarget : MonoBehaviour
{
    public Vector3 targetPosition;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Destroy(gameObject);
        player.transform.position = new Vector3(targetPosition.x, player.transform.position.y, targetPosition.z);
    }
}
