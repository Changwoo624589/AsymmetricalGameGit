using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDistractions : MonoBehaviour
{
     float toyVelocity = 30f;
    public float canThrow = 0f;

   
    public GameObject ballPrefab;



    private void Start()
    {
     
    }
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0f, 0f, 1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);


            Rigidbody rb = newBall.GetComponent<Rigidbody>();


            rb.AddForce(gameObject.transform.forward * toyVelocity + Vector3.up * 30f); 
            //canThrow = Time.time + 1f; 
        }
    }

  
}
