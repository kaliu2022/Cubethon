using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;
    public float FollowDist = 5.0f; //how far back to keep the camera
                                    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z - transform.position.z > FollowDist)
        {
            Vector3 p = transform.position;
            p.z = player.transform.position.z - FollowDist;
            transform.position = p;
        }
    }
}

