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
	titleStyle.fontSize = 24;
	GUI.Label (Rect (10, 10, 500, 100), PlayerMove.updatedTime, titleStyle);
}