using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CarMovingTest : MonoBehaviour
{

    public Rigidbody rb;
    public Transform car;
    public float speed = 25;


    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    public Animator wheel1Animator;
    public Animator wheel2Animator;
    public Animator wheel3Animator;
    public Animator wheel4Animator; 


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //transform.Translate(forward * speed * Time.deltaTime);
            rb.AddForce(transform.forward * speed);
           
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);

        }
        else
        {
            wheel1Animator.SetBool("isDriving", false);
            wheel2Animator.SetBool("isDriving2", false);
            wheel3Animator.SetBool("isDriving3", false);
            wheel4Animator.SetBool("isDriving4", false);

        }
        if (Input.GetKey("s"))
        {
            //transform.Translate(backward * speed * Time.deltaTime);
            rb.AddForce(transform.forward * -speed);
            
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);


        }
        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
            
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);


        }
        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
          
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);



            //Animation controls below
            //Not sure why getkey by itself doesn't play animations 

        }
    }

}
