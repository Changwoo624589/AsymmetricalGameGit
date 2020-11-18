using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDistractions : MonoBehaviour
{
    public float toyVelocity = 0.5f;
    public float canThrow = 0f;

    public GameObject ball;
    public GameObject ball1;

    public Rigidbody rb;

    private void Start()
    {
     
    }
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0f, 0f, 1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            GameObject ball = (GameObject)(Instantiate(
                ball1, transform.position, Quaternion.identity));


            ball.GetComponent<Rigidbody>().velocity = direction * toyVelocity;

            rb.AddForce(gameObject.transform.forward * toyVelocity); 
            //canThrow = Time.time + 1f; 
        }
    }

  
}
