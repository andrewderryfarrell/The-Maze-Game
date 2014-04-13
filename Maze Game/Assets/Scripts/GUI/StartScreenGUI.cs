using UnityEngine;
using System.Collections;

public class StartScreenGUI : MonoBehaviour 
{
    public float titleLabelYAxis;
    public float playButtonYAxis;
    public float loadButtonYAxis;
    public float exitButtonYAxis;
    
    public GUIStyle buttonStyle;
    public GUIStyle titleStyle;
    private bool isFirst = true;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Application.LoadLevel(1);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            print("You want to load a level");
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
        titleStyle.fontSize = (int)(.16f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;

        GUI.Label(new Rect(Screen.width * .20f, Screen.height * titleLabelYAxis, Screen.width, Screen.height * .2f), "The Maze Game", titleStyle);

        //Button Style
        buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.white;
        buttonStyle.hover.textColor = Color.cyan;
        buttonStyle.focused.textColor = Color.cyan;
        buttonStyle.alignment = TextAnchor.MiddleCenter;
        buttonStyle.fontSize = (int)(.07f * Screen.height);
        buttonStyle.fontStyle = FontStyle.Italic;

        //Play Game Button
        GUI.SetNextControlName("Play");
        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * playButtonYAxis, Screen.width * .5f, Screen.height * .1f), "Play Game", buttonStyle))
        {
            //Pressed
            Application.LoadLevel("Game");
        }

        //Load Level Button
        GUI.SetNextControlName("Load");
        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * loadButtonYAxis, Screen.width * .5f, Screen.height * .1f), "Load Level", buttonStyle))
        {
            //Pressed
            print("You clicked the Load Level Button!");
        }

        //Exit Game Button
        GUI.SetNextControlName("Exit");
        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * exitButtonYAxis, Screen.width * .5f, Screen.height * .1f), "Exit Game", buttonStyle))
        {
            //Pressed
            Application.Quit();
        }
    }
}
