using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonCooldownController : MonoBehaviour
{
    public Image wiperCooldown;
    public Image hornCooldown;
    public Image toyCooldown;
    public Image vomitCooldown;

    public float cooldown =5;

    float toyTimeCooldown = 6f;
    float vomitTimeCooldown = 7f;

    bool isCooldown;
    bool isHornCooldown;
    bool isToyCooldown;
    bool isVomitCooldown;

    public Animator Wiper1Animator;
    public Animator Wiper2Animator;

    public AudioSource horn;

    bool hornPlayed = false;

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
                if(!horn.isPlaying && !hornPlayed)
                {
                    horn.Play();
                    hornPlayed = true;
                }else
                {
                            hornPlayed = false;
                        
                }
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

        if (Input.GetKeyDown(KeyCode.U))
        {
            isToyCooldown = true;
        }
        if (isToyCooldown)
        {
            toyCooldown.fillAmount += 1 / toyTimeCooldown * Time.deltaTime;

            if(toyCooldown.fillAmount >= 1)
            {
                toyCooldown.fillAmount = 0;
                isToyCooldown = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            isVomitCooldown = true;
        }
        if (isVomitCooldown)
        {
            vomitCooldown.fillAmount += 1 / vomitTimeCooldown * Time.deltaTime;

            if(vomitCooldown.fillAmount >= 1)
            {
                vomitCooldown.fillAmount = 0;
                isVomitCooldown = false;
            }
        }
    }
}
