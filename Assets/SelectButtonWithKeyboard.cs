using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class SelectButtonWithKeyboard : MonoBehaviour
{

    public string key;

    public Animator wiper1Animator;
    public Animator wiper2Animator;




    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject); 
        }

        if(Input.GetKeyDown(key) && this.gameObject.tag=="Wiper")
        {
                wiper1Animator.SetBool("1wiperActivated", true);
                wiper2Animator.SetBool("2wiperActivated", true); 
        }
        else

        {
            wiper1Animator.SetBool("1wiperActivated", false);
            wiper2Animator.SetBool("2wiperActivated", false);
        }
    }
}

