﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay;
    private GameObject ball;

    private void Start()
    {
        ball = FindObjectOfType<Ball>().gameObject;
    }


    void Update ()
    {
        //get the current paddle position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        if (autoPlay)
        {
            paddlePosition.x = ball.transform.position.x;
        }
        else
        {
            //get horizontal position 
            float mousePositionInBlocks = Input.mousePosition.x / Screen.width * 16 - 8;

            paddlePosition.x = mousePositionInBlocks;
        }

        //set this paddle object to saved position
        this.gameObject.transform.position = paddlePosition;
	}
}
