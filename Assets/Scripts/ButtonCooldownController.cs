using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonCooldownController : MonoBehaviour
{
    public Image wiperCooldown;
    public Image hornCooldown; 

    public float cooldown =5;

    bool isCooldown;
    bool isHornCooldown;

    public Animator Wiper1Animator;
    public Animator Wiper2Animator;

    // Update is called once per frame
    void Update()
    {

        ///wiper cooldown///

        if (Input.GetKeyDown(KeyCode.P))
        {
            isCooldown = true;

            Wiper1Animator.SetBool("1wiperActivated", true);
            Wiper2Animator.SetBool("2wiperActivated", true); 
        }
        if (isCooldown)
        {
            wiperCooldown.fillAmount += 1 / cooldown * Time.deltaTime;

            if(wiperCooldown.fillAmount >= 1)
            {
                wiperCooldown.fillAmount = 0;
                isCooldown = false;

                Wiper1Animator.SetBool("1wiperActivated", false);
                Wiper2Animator.SetBool("2wiperActivated", false);
            }


        ///horn cooldown///
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            isHornCooldown = true;
        }
        if (isHornCooldown)
        {
            hornCooldown.fillAmount += 1 / cooldown * Time.deltaTime; 

            if (hornCooldown.fillAmount >= 1)
            {
                hornCooldown.fillAmount = 0;
                isHornCooldown = false;
            }
        }
    }
}
