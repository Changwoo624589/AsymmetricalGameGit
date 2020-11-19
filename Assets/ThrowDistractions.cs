using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDistractions : MonoBehaviour
{
     float toyVelocity = 30f;
    public float canThrow = 0f;

    public GameObject[] distractions;

    public Rigidbody[] rbs;


    int index;

    private void Start()
    {
        distractions = GameObject.FindGameObjectsWithTag("Toy");

        index = Random.Range(0, distractions.Length - 1);
        

        rbs = new Rigidbody[distractions.Length - 1];

        for (int i = 0; i < distractions.Length; i++)
        {
            rbs[i] = distractions[i].GetComponent<Rigidbody>();
        }


    }
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(-2f, 0f, 1f);

        if (Input.GetKeyDown(KeyCode.U) && Time.time > canThrow)
        {
            //index = Random.Range(0, distractions.Length - 1);
            Instantiate(distractions[index], transform.position, Quaternion.identity);
           
            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].AddForce(gameObject.transform.forward * toyVelocity + Vector3.up * 30f);
            }

            canThrow = Time.time + 6f;
        }
    }

    //void rbEffects()
    //{
    //  for(int i = 0; i < rbs.Length; i++)
    //    {
    //        rbs[i].AddForce(gameObject.transform.forward * toyVelocity + Vector3.up * 30f);
    //    }
    //}

}
