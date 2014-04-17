using UnityEngine;
using System.Collections;

public class NextLevelScreen : MonoBehaviour 
{
    public float titleLabelYAxis1;
    public float titleLabelYAxis2;
    
    public GUIStyle buttonStyle;
    public GUIStyle titleStyle;


    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.white;
        titleStyle.fontSize = (int)(.25f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("windows_command_prompt");

        GUI.Label(new Rect(Screen.width * .05f, Screen.height * titleLabelYAxis1, Screen.width, Screen.height * .2f), "T A K E  I T  T O  T H E", titleStyle);
        GUI.Label(new Rect(Screen.width * .15f, Screen.height * titleLabelYAxis2, Screen.width, Screen.height * .2f), "N E X T  L E V E L", titleStyle);
        
    }
}
