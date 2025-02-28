using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A simple tutorial for particle system based trail: https://www.youtube.com/watch?v=agr-QEsYwD0&t=312s

public class DrawFingerDraw : MonoBehaviour
{
    public GameObject drawTrail;

    private float timeCount = 0, disapperTime = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DrawFingerEventListener.ifPose)
        {
            timeCount = 0;
            drawTrail.transform.position = DrawFingerEventListener.drawPoint;
            drawTrail.SetActive(true);
        }
        else
        {
            timeCount+= Time.deltaTime;
            if(timeCount > disapperTime)
                drawTrail.SetActive(false);
        }
    }
}
