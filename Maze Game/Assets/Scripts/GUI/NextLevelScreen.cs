using UnityEngine;
using System.Collections;

public class NextLevelScreen : MonoBehaviour 
{
    public float titleLabelYAxis1;
    public float titleLabelYAxis2;
    
    public GUIStyle buttonStyle;
    public GUIStyle titleStyle;

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
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.white;
        titleStyle.fontSize = (int)((x * correctWidth)/9);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("windows_command_prompt");

        GUI.Label(new Rect(x * correctWidth * .10f, y * correctHeight * titleLabelYAxis1, x * correctWidth, y * correctHeight * .2f), "T A K E  I T  T O  T H E", titleStyle);
        GUI.Label(new Rect(x * correctWidth * .18f, y * correctHeight * titleLabelYAxis2, x * correctWidth, y * correctHeight * .2f), "N E X T  L E V E L", titleStyle);
        
    }
}
