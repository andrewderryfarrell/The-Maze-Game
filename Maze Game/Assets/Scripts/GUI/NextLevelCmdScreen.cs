using UnityEngine;
using System.Collections;

public class NextLevelCmdScreen : MonoBehaviour
{
    public float firstLineYAxis;
    public float secondLineYAxis;
    public float thirdLineYAxis;
    public float fourthLineYAxis;
    public float Line5YAxis;
    public float Line6YAxis;
    public float Line7YAxis;
    public float Line8YAxis;
    public float Line9YAxis;
    public float Line10YAxis;
    public float Line11YAxis;
    public float Line12YAxis;
    public float Line13YAxis;


    public GUIStyle textStyle;

    private Vector2 resolution;
    private float correctWidth = 1600.0f;
    private float correctHeight = 729.0f;
    private float x;
    private float y;

    void Start()
    {
        resolution = new Vector2(Screen.width, Screen.height);
        x = Screen.width / correctWidth;
        y = Screen.height / correctHeight;
    }

    void Update()
    {
        if (Screen.width != resolution.x || Screen.height != resolution.y)
        {
            resolution = new Vector2(Screen.width, Screen.height);
            x = Screen.width / correctWidth;
            y = Screen.height / correctHeight;
        }
    }

    void OnGUI()
    {
        textStyle = new GUIStyle(GUI.skin.label);
        textStyle.normal.textColor = Color.white;
        textStyle.fontSize = (int)((x * correctWidth) / 45);
        textStyle.font = (Font)Resources.Load("windows_command_prompt");
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * firstLineYAxis, x * correctWidth, y * correctHeight * .2f), "C:\\>ver", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * secondLineYAxis, x * correctWidth, y * correctHeight * .2f), "MAZBox Version 1.0. Reported MAZ version 1.00.", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * thirdLineYAxis, x * correctWidth, y * correctHeight * .2f), "C:\\>gainprivledge", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE version 1.29", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line5YAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE privlevel   auth", textStyle);
        GUI.Label(new Rect(x * correctWidth * .20f, y * correctHeight * Line6YAxis, x * correctWidth, y * correctHeight * .2f), "privlevel   requested privledge level", textStyle);
        GUI.Label(new Rect(x * correctWidth * .20f, y * correctHeight * Line7YAxis, x * correctWidth, y * correctHeight * .2f), "auth request   privledge authentication", textStyle);
        string text = "C:\\>gainprivledge " + Variables.level + " collectedAuth.txt";
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line8YAxis, x * correctWidth, y * correctHeight * .2f), text, textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line9YAxis, x * correctWidth, y * correctHeight * .2f), "...", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line10YAxis, x * correctWidth, y * correctHeight * .2f), "...", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line11YAxis, x * correctWidth, y * correctHeight * .2f), "...", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line12YAxis, x * correctWidth, y * correctHeight * .2f), "Privledge Authorized", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * Line13YAxis, x * correctWidth, y * correctHeight * .2f), "C:\\>accessegment next", textStyle);
        

    }
}
