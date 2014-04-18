using UnityEngine;
using System.Collections;

public class NextLevelCmdScreen : MonoBehaviour
{
    public float titleLabelYAxis;
    public float firstLineYAxis;
    public float secondLineYAxis;
    public float thirdLineYAxis;
    public float fourthLineYAxis;
    public float errorLineYAxis;
    public float retryLineYAxis;

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
        textStyle.fontSize = (int)((x * correctWidth) / 55);
        textStyle.font = (Font)Resources.Load("windows_command_prompt");
        
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * firstLineYAxis, x * correctWidth, y * correctHeight * .2f), "C:\\>ver", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * secondLineYAxis, x * correctWidth, y * correctHeight * .2f), "MAZBox Version 1.0. Reported MAZ version 1.00.", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * thirdLineYAxis, x * correctWidth, y * correctHeight * .2f), "C:\\>gainprivledge", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE version 1.29", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE privlevel auth", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "privlevel requested privledge level", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "auth request privledge authentication", textStyle);
        string text = "C:\\>gainprivledge " + Variables.level + "collectedAuth.txt";
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), text, textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE version 1.29", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "GAINPRIVLEDGE version 1.29", textStyle);

        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * errorLineYAxis, x * correctWidth, y * correctHeight * .2f), "Error: YU : B33N : C4U5HT", textStyle);
        GUI.Label(new Rect(x * correctWidth * .38f, y * correctHeight * retryLineYAxis, x * correctWidth, y * correctHeight * .2f), "Press any key to retry level", textStyle);
        

    }
}
