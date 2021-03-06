﻿using UnityEngine;
using System.Collections;

public class ScannerBeam : MonoBehaviour 
{
    public bool isShowingBeam = true;
    public float secondsToShow = 2.0f;
    public float secondsToNotShow = 5.0f;
    public float flickerSecondsInterval = 0.3f;

    private float flickerTimer = 0;
    private float timer = 0;
    private float stopTimer = 0;
    private Transform myTransform;
    private Transform target;
    private GameObject player;

    void Start()
    {
        myTransform = transform;
        player = GameObject.Find("Player");
    }

	// Use this for initialization
    void Update()
    {
        if(isShowingBeam == true)
        {
            flickerTimer += Time.deltaTime;
        }
        else
        {
            stopTimer += Time.deltaTime;
        }

        if(isShowingBeam == false && stopTimer >= secondsToNotShow)
        {
            this.renderer.enabled = true;
            this.collider2D.enabled = true;
            stopTimer = 0;
            timer = 0;
            flickerTimer = 0;
            isShowingBeam = true;
        }

        if (flickerTimer >= flickerSecondsInterval)
        {
            timer += flickerTimer;
            if (timer >= secondsToShow)
            {
                this.renderer.enabled = false;
                this.collider2D.enabled = false;
                stopTimer = 0;
                timer = 0;
                flickerTimer = 0;
                isShowingBeam = false;
            }
            else if(isShowingBeam == true)
            {
                if (this.renderer.enabled == true)
                {
                    this.renderer.enabled = false;
                }
                else
                {
                    this.renderer.enabled = true;
                    this.renderer.enabled = true;
                }
                flickerTimer = 0;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Application.LoadLevel("CaughtScreen");
        }
    }
}
