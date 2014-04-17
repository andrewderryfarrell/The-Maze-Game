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


    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.green;
        titleStyle.fontSize = (int)(.25f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("windows_command_prompt");

        GUI.Label(new Rect(Screen.width * .24f, Screen.height * titleLabelYAxis, Screen.width, Screen.height * .2f), "Load Level", titleStyle);

        //Button Style
        buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.white;
        buttonStyle.hover.textColor = Color.cyan;
        buttonStyle.focused.textColor = Color.cyan;
        buttonStyle.alignment = TextAnchor.MiddleCenter;
        buttonStyle.fontSize = (int)(.07f * Screen.height);
        buttonStyle.fontStyle = FontStyle.Italic;
        buttonStyle.font = (Font)Resources.Load("windows_command_prompt");

        //Levels
        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level1YAxis, Screen.width * .5f, Screen.height * .1f), "Level 1", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level2YAxis, Screen.width * .5f, Screen.height * .1f), "Level 2", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level3YAxis, Screen.width * .5f, Screen.height * .1f), "Level 3", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(3);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level4YAxis, Screen.width * .5f, Screen.height * .1f), "Level 4", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(4);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level5YAxis, Screen.width * .5f, Screen.height * .1f), "Level 5", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(5);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level6YAxis, Screen.width * .5f, Screen.height * .1f), "Level 6", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(6);
        }

        if (GUI.Button(new Rect(Screen.width * .01f, Screen.height * backYAxis, Screen.width * .2f, Screen.height * .1f), "Back", buttonStyle))
        {
            //Pressed
            Application.LoadLevel("StartScreen");
        }

    }
}
