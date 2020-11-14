using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenInstructions : MonoBehaviour
{

    public GameObject panel; 


   public void OpenPanel()
    {
        if(panel != null)
        {
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }
}
