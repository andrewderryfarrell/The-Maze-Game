using UnityEngine;
using System.Collections;

public class LoadLevelScreen : MonoBehaviour 
{
    public float titleLabelYAxis;
    public float level1YAxis;
    public float level2YAxis;
    public float level3YAxis;
    public float level4YAxis;
    public float level5YAxis;
    public float level6YAxis;
    public float backYAxis;

    
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


        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            Variables.level = 1;
            Application.LoadLevel(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Variables.level = 2;
            Application.LoadLevel(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            Variables.level = 3;
            Application.LoadLevel(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            Variables.level = 4;
            Application.LoadLevel(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            Variables.level = 5;
            Application.LoadLevel(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            Variables.level = 6;
            Application.LoadLevel(6);
        }


    }

    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.green;
        titleStyle.fontSize = (int)((x * correctWidth) / 9);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("windows_command_prompt");

        GUI.Label(new Rect(x * correctWidth * .26f, y * correctHeight * titleLabelYAxis, x * correctWidth, y * correctHeight * .2f), "Load Level", titleStyle);

        //Button Style
        buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.white;
        buttonStyle.hover.textColor = Color.cyan;
        buttonStyle.focused.textColor = Color.cyan;
        buttonStyle.alignment = TextAnchor.MiddleCenter;
        buttonStyle.fontSize = (int)((x * correctWidth) / 31);
        buttonStyle.fontStyle = FontStyle.Italic;
        buttonStyle.font = (Font)Resources.Load("windows_command_prompt");

        //Levels
        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level1YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 1", buttonStyle))
        {
            //Pressed
            Variables.level = 1;
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level2YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 2", buttonStyle))
        {
            //Pressed
            Variables.level = 2;
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level3YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 3", buttonStyle))
        {
            //Pressed
            Variables.level = 3;
            Application.LoadLevel(3);
        }

        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level4YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 4", buttonStyle))
        {
            //Pressed
            Variables.level = 4;
            Application.LoadLevel(4);
        }

        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level5YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 5", buttonStyle))
        {
            //Pressed
            Variables.level = 5;
            Application.LoadLevel(5);
        }

        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * level6YAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Level 6", buttonStyle))
        {
            //Pressed
            Variables.level = 6;
            Application.LoadLevel(6);
        }

        if (GUI.Button(new Rect(x * correctWidth * .01f, y * correctHeight * backYAxis, x * correctWidth * .2f, y * correctHeight * .1f), "Back", buttonStyle))
        {
            //Pressed
            Application.LoadLevel("StartScreen");
        }

    }
}
