using UnityEngine;
using System.Collections;

public class CaughtScreenGUI : MonoBehaviour
{
    public float titleLabelYAxis;
    public float firstLineYAxis;
    public float secondLineYAxis;
    public float thirdLineYAxis;
    public float fourthLineYAxis;
    public float errorLineYAxis;
    public float retryLineYAxis;

    public GUIStyle titleStyle;
    public GUIStyle textStyle;
    private Texture2D grayBackground;

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


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Application.LoadLevel(0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) ||
                Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) ||
                Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) ||
                Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.D))
        {
            //Do nothing
            //This is to fix the issue with if you had that key down while you were playing then got caught you would immedietely restart
        }

        else if (Input.anyKeyDown)
        {
            Application.LoadLevel(Variables.level);
        }
    }

    void OnGUI()
    {
        titleStyle = new GUIStyle(GUI.skin.label);
        titleStyle.normal.textColor = Color.gray;
        titleStyle.fontSize = (int)((x * correctWidth) / 31);
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.font = (Font)Resources.Load("Lucida Console");

        textStyle = new GUIStyle(GUI.skin.label);
        textStyle.normal.textColor = Color.white;
        textStyle.fontSize = (int)((x * correctWidth) / 55);
        textStyle.font = (Font)Resources.Load("Lucida Console");
        
        GUI.Label(new Rect(x * correctWidth * .38f, y * correctHeight * titleLabelYAxis, x * correctWidth, y * correctHeight * .2f), "The Maze Game", titleStyle);

        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * firstLineYAxis, x * correctWidth, y * correctHeight * .2f), "You have been caught. To Continue:", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * secondLineYAxis, x * correctWidth, y * correctHeight * .2f), "Press Escape to exit game, or", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * thirdLineYAxis, x * correctWidth, y * correctHeight * .2f), "Press Enter to return to Main Menu. If you do this,", textStyle);
        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * fourthLineYAxis, x * correctWidth, y * correctHeight * .2f), "you will lose all progress.", textStyle);

        GUI.Label(new Rect(x * correctWidth * .15f, y * correctHeight * errorLineYAxis, x * correctWidth, y * correctHeight * .2f), "Error: YU : B33N : C4U5HT", textStyle);
        GUI.Label(new Rect(x * correctWidth * .38f, y * correctHeight * retryLineYAxis, x * correctWidth, y * correctHeight * .2f), "Press any key to retry level", textStyle);
        

    }
}
