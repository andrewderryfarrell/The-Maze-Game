static var level : int = 1;
static var titleStyle : GUIStyle;

private var csScript : Variables;

function Start() {
    GoToNextLevel();
    csScript = this.GetComponent("Variables");
}

function GoToNextLevel() {
    csScript.level = csScript.level + 1;
	yield WaitForSeconds(5);
	if(csScript.level > 6)
	{
        //Go to first level if at the last level
	    csScript.level = 1;
	}
	Application.LoadLevel("Level" + csScript.level);	
}

function OnGUI() {
	titleStyle = new GUIStyle();
	titleStyle.font = Resources.Load("windows_command_prompt", Font);
	titleStyle.normal.textColor = Color.white;
	titleStyle.fontSize = 64;
	GUI.Label (Rect ((Screen.width / 2) - (Screen.width / 15), 8 * Screen.height / 10, Screen.width, Screen.height), PlayerMove.updatedTime, titleStyle);
}