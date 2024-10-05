using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool isRed;
    private bool isGreen;
    private bool is8Ball = false;
    private bool isCueBall = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isCueBall()
    {
        return isCueBall;
    }

    public bool is8Ball()
    {
        return is8Ball;
    }

    public bool isBallRed()
    {
        return isRed;
    }

    public void BallSetup(bool red)
    {
        isRed = red;
        if (isRed)
        {
            GetComponent<Renderer>.material.color = ConsoleColor.Red;
        }
        else
        {
            GetComponent<Renderer>.material.color = ConsoleColor.Blue;
        }
    }

    public void MakeCueBall()
    {
        isCueBall = true;
    }

    public void Make8Ball()
    {
        is8Ball = true;
        GetComponent<Renderer>().material.color = ConsoleColor.Black;
    }
}
