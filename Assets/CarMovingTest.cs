using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovingTest : MonoBehaviour
{

    public Rigidbody rb;
    public Transform car;
    public float speed = 25;


    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1); 

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //transform.Translate(forward * speed * Time.deltaTime);
            rb.AddForce(transform.forward * speed); 
        }
        if (Input.GetKey("s"))
        {
            //transform.Translate(backward * speed * Time.deltaTime);
            rb.AddForce(transform.forward * -speed);
        }
        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationRight); 
        }
        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationLeft); 
        }
    }
}
