using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuger : MonoBehaviour {
    public Boolean autoIntercept = false;
    public Boolean highSpeedBall = false;

    public GameObject player;
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        if (highSpeedBall) {
            ball.GetComponent<Rigidbody>().AddForce(transform.forward * 1500);
            ball.GetComponent<StartShot>().speed = 37.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (autoIntercept) {
            if (ball.transform.position.x <= -5.5) {
                player.transform.position = new Vector3(
                    player.transform.position.x,
                    player.transform.position.y,
                    ball.transform.position.z);
            }
        }   
    }
}
