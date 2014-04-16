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

    
    public GUIStyle buttonStyle;
    public GUIStyle titleStyle;


    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.green;
        titleStyle.fontSize = (int)(.16f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("Petyka - Retro Computer___SHORT");

        GUI.Label(new Rect(Screen.width * .20f, Screen.height * titleLabelYAxis, Screen.width, Screen.height * .2f), "Load Level", titleStyle);

        //Button Style
        buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.white;
        buttonStyle.hover.textColor = Color.cyan;
        buttonStyle.focused.textColor = Color.cyan;
        buttonStyle.alignment = TextAnchor.MiddleCenter;
        buttonStyle.fontSize = (int)(.05f * Screen.height);
        buttonStyle.fontStyle = FontStyle.Italic;
        buttonStyle.font = (Font)Resources.Load("Petyka - Retro Computer___SHORT");

        //Levels
        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level1YAxis, Screen.width * .5f, Screen.height * .1f), "Level One", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level2YAxis, Screen.width * .5f, Screen.height * .1f), "Level Two", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level3YAxis, Screen.width * .5f, Screen.height * .1f), "Level Three", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(3);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level4YAxis, Screen.width * .5f, Screen.height * .1f), "Level Four", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(4);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level5YAxis, Screen.width * .5f, Screen.height * .1f), "Level Five", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(5);
        }

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * level6YAxis, Screen.width * .5f, Screen.height * .1f), "Level Six", buttonStyle))
        {
            //Pressed
            Application.LoadLevel(6);
        }

    }
}
