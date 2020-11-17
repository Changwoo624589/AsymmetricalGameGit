﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisionTest : MonoBehaviour
{

    public AudioSource ahh; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OldPerson"))
        {
            ahh.Play(); 
        }

        if (collision.gameObject.CompareTag("StreetObstacle"))
        {
           Healthbar.health -= 20f;
        }

        //  if (Healthbar.health == 0)
        // {
        //    SceneManager.LoadScene("GameOver");
        // }
    }
}
