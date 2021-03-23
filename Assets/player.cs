using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            //Debug.Log("up arrow pressed");
            GetComponent< Rigidbody >().AddForce(Vector3.forward, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("up arrow pressed");
            GetComponent<Rigidbody>().AddForce(Vector3.back, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Log("up arrow pressed");
            GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("up arrow pressed");
            GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("up arrow pressed");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 4, ForceMode.VelocityChange);
        }
    }
}
