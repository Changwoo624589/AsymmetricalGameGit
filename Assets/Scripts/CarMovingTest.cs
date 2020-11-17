using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CarMovingTest : MonoBehaviour
{

    public Rigidbody rb;
    public Transform car;
    public float speed = 25;
    public Transform steeringWheel;
    public float swRot;
    public float swRotSpeed;
    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    public Animator wheel1Animator;
    public Animator wheel2Animator;
    public Animator wheel3Animator;
    public Animator wheel4Animator; 

    public AudioSource driving_sound;

    bool soundPlayed = false;

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
            
            // driving_sound.Play();
            if (!driving_sound.isPlaying && !soundPlayed)
                {
                    driving_sound.Play();
                    soundPlayed = true;
                }

        }
        else
        {
            
            wheel1Animator.SetBool("isDriving", false);
            wheel2Animator.SetBool("isDriving2", false);
            wheel3Animator.SetBool("isDriving3", false);
            wheel4Animator.SetBool("isDriving4", false);
                if (driving_sound.isPlaying && soundPlayed)
                {
                    driving_sound.Stop();
                    soundPlayed = false;
                }
            // driving_sound.Stop();

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
            //steeringWheel Script
            if (swRot > 0) { swRot = 0; }
            swRot -= swRotSpeed*Time.fixedDeltaTime;
            steeringWheel.Rotate(0, 0, swRot);
            //
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
            
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);


        }
        if (Input.GetKey("a"))
        {
            //steeringWheel Script
            if (swRot < 0) { swRot = 0; }
            swRot += swRotSpeed * Time.fixedDeltaTime;
            steeringWheel.Rotate(0, 0, swRot);
            //
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime * 2);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
          
            wheel1Animator.SetBool("isDriving", true);
            wheel2Animator.SetBool("isDriving2", true);
            wheel3Animator.SetBool("isDriving3", true);
            wheel4Animator.SetBool("isDriving4", true);
<<<<<<< HEAD
  
=======


            //Animation controls below
            //Not sure why getkey by itself doesn't play animations 
>>>>>>> c499b9d7a1583bd5a6633311397c3abf636d7346

        }
        
    }

}
