using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StartShot : MonoBehaviour {
    private bool rollFlag;
    public float speed = 10.0f;
    void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        rollFlag = true;
    }

    private void Update() {
        if (rollFlag && Input.GetKey(KeyCode.Q)) {
            Vector3 tmp = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(
                (float) (Math.Sin(0.25 * Math.PI) * tmp.z * -1.0f + Math.Cos(0.25 * Math.PI) * tmp.x),
                tmp.y,
                (float) (Math.Sin(0.25 * Math.PI) * tmp.x + Math.Cos(0.25 * Math.PI) * tmp.z)
            ).normalized * speed;
            rollFlag = false;
        } else if (rollFlag && Input.GetKey(KeyCode.E)) {
            Vector3 tmp = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(
                (float) (Math.Sin(-0.25 * Math.PI) * tmp.z * -1.0f + Math.Cos(-0.25 * Math.PI) * tmp.x),
                tmp.y,
                (float) (Math.Sin(-0.25 * Math.PI) * tmp.x + Math.Cos(-0.25 * Math.PI) * tmp.z)
            ).normalized * speed;
            rollFlag = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        rollFlag = true;
    }
}
