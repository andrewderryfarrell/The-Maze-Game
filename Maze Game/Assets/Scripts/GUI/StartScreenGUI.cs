using UnityEngine;
using System.Collections;

public class StartScreenGUI : MonoBehaviour 
{
    public float titleLabelYAxis1;
    public float titleLabelYAxis2;
    public float playButtonYAxis;
    public float loadButtonYAxis;
    public float exitButtonYAxis;
    
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


        if (Input.GetKeyDown(KeyCode.P))
        {
            Variables.level = 1;
            Application.LoadLevel(1);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Application.LoadLevel("LoadLevelScreen");
        }
        else if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.green;
        titleStyle.fontSize = (int)((x * correctWidth) / 9);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("windows_command_prompt");

        GUI.Label(new Rect(x * correctWidth * .42f, y * correctHeight * titleLabelYAxis1, x * correctWidth, y * correctHeight * .2f), "The", titleStyle);
        GUI.Label(new Rect(x * correctWidth * .28f, y * correctHeight * titleLabelYAxis2, x * correctWidth, y * correctHeight * .2f), "Maze Game", titleStyle);

        //Button Style
        buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.white;
        buttonStyle.hover.textColor = Color.cyan;
        buttonStyle.focused.textColor = Color.cyan;
        buttonStyle.alignment = TextAnchor.MiddleCenter;
        buttonStyle.fontSize = (int)((x * correctWidth) / 31);
        buttonStyle.fontStyle = FontStyle.Italic;
        buttonStyle.font = (Font)Resources.Load("windows_command_prompt");

        //Play Game Button
        GUI.SetNextControlName("Play");
        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * playButtonYAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Play Game", buttonStyle))
        {
            //Pressed
            Variables.level = 1;
            Application.LoadLevel(1);
        }

        //Load Level Button
        GUI.SetNextControlName("Load");
        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * loadButtonYAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Load Level", buttonStyle))
        {
            //Pressed
            Application.LoadLevel("LoadLevelScreen");
        }

        //Exit Game Button
        GUI.SetNextControlName("Exit");
        if (GUI.Button(new Rect(x * correctWidth * .25f, y * correctHeight * exitButtonYAxis, x * correctWidth * .5f, y * correctHeight * .1f), "Exit Game", buttonStyle))
        {
            //Pressed
            Application.Quit();
        }
    }
}
