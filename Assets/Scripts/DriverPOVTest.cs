using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverPOVTest : MonoBehaviour
{

    public float mouseSensitivity = 400f;

    public Transform playerBody;

    float xRotation = 0f; 


    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; 

    }


    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity*Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //Debug.Log(mouseX);

        //xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        mouseX = Mathf.Clamp(mouseX, -30f, 30f);
        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        this.transform.Rotate (Vector3.up * mouseX);
        playerBody.Rotate (Vector3.up * mouseX);
        //This rotation can be put in for the final model, maybe only attached to the head, so the model rotates in direction of the camera// 
        


    }
}
