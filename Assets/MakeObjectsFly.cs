using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjectsFly : MonoBehaviour
{
    public Rigidbody rb; 

    Vector3 m_NewForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }

    void AddForce()
    {
        m_NewForce = new Vector3(2f, 3f, 10f);
     

        rb.AddForce(m_NewForce, ForceMode.Impulse); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            AddForce(); 
        }
    }
}
