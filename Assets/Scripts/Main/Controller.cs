using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 7.5f);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -7.5f);
        }
        else {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        
    }
}
