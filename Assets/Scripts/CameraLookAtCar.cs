using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtCar : MonoBehaviour
{

    public GameObject car;
    Vector3 lookAtOffset; 

    // Start is called before the first frame update
    void Start()
    {
        lookAtOffset = new Vector3(0.1f, 3f, 0f); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(car.transform.position + lookAtOffset);  
    }
}
