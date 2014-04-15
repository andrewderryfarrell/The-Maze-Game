using UnityEngine;
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
                }
                flickerTimer = 0;
            }
        }

    }
}
