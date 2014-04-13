using UnityEngine;
using System.Collections;

public class CaughtScreenGUI : MonoBehaviour
{
    public float titleLabelYAxis;
    public float firstLineYAxis;
    public float secondLineYAxis;
    public float thirdLineYAxis;
    public float retryLineYAxis;

    public GUIStyle titleStyle;
    public GUIStyle textStyle;
    private Texture2D grayBackground;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Application.LoadLevel(0);
        }
        else if (Input.anyKeyDown)
        {
            //Get the level variable assigned in the player class and load level
            print("You pressed a key! You want to rety the level!");
        }
    }

    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.gray;
        titleStyle.fontSize = (int)(.07f * Screen.height);
        titleStyle.fontStyle = FontStyle.Bold;

        textStyle = new GUIStyle(GUI.skin.label);
        textStyle.normal.textColor = Color.white;
        textStyle.fontSize = (int)(.04f * Screen.height);

        
        GUI.Label(new Rect(Screen.width * .38f, Screen.height * titleLabelYAxis, Screen.width, Screen.height * .2f), "The Maze Game", titleStyle);

        GUI.Label(new Rect(Screen.width * .15f, Screen.height * firstLineYAxis, Screen.width, Screen.height * .2f), "You have been caught. To Continue:", textStyle);
        GUI.Label(new Rect(Screen.width * .15f, Screen.height * secondLineYAxis, Screen.width, Screen.height * .2f), "Press Escape to exit game, or", textStyle);
        GUI.Label(new Rect(Screen.width * .15f, Screen.height * thirdLineYAxis, Screen.width, Screen.height * .2f), "Press Enter to return to Main Menu.", textStyle);

        GUI.Label(new Rect(Screen.width * .38f, Screen.height * retryLineYAxis, Screen.width, Screen.height * .2f), "Press any key to retry level", textStyle);

        

    }
}
