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
        titleStyle.fontSize = (int)(.16f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("Petyka - Retro Computer___SHORT");

        GUI.Label(new Rect(Screen.width * .15f, Screen.height * titleLabelYAxis1, Screen.width, Screen.height * .2f), "TAKE IT TO THE", titleStyle);
        GUI.Label(new Rect(Screen.width * .25f, Screen.height * titleLabelYAxis2, Screen.width, Screen.height * .2f), "NEXT LEVEL", titleStyle);
        
    }
}
