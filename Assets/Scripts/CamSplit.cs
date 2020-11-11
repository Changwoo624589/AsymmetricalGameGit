using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSplit : MonoBehaviour
{
    public Camera cam;
    public int camNum;
    void Start()
    {
        if (camNum == 1)
        {
            cam.rect = new Rect(0, 0f, .5f, 1f);
        }
        else if (camNum == 2) {
            cam.rect = new Rect(0.5f, 0f, .5f, 1f);
        }
    }

    void Update()
    {
        
    }
}
