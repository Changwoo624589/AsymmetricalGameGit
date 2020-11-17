using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    Image healthbar;


    float fullHealth = 100f;
    public static float health;
    void Start()
    {
        healthbar= GetComponent<Image>();
        health = fullHealth;
       
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / fullHealth;
    }
}
