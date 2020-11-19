using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Healthbar.health -= 10f; 
        }

        if (collision.gameObject.CompareTag("StreetObstacle"))
        {
           Healthbar.health -= 20f;
        }

         if (Healthbar.health == 0f)
        {
           SceneManager.LoadScene("GameOver");
        }
         if (collision.gameObject.CompareTag("Daycare"))
        {
            SceneManager.LoadScene("Win");
        }

    }
}
