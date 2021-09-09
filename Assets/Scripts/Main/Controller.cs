using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.z < 4.4f) {
            transform.position += transform.forward * 10f * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.RightArrow) && transform.position.z > -4.4f) {
            transform.position -= transform.forward * 10f * Time.deltaTime;
        }
    }
}
