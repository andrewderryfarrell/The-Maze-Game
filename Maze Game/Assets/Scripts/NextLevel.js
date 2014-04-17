static var level : int = 1;
static var titleStyle : GUIStyle;

function Start() {
	GoToNextLevel();
}

function GoToNextLevel() {
	yield WaitForSeconds(5);
	level++;
	Application.LoadLevel("Level" + level);	
}

function OnGUI() {
	titleStyle = new GUIStyle();
	titleStyle.font = Resources.Load("windows_command_prompt", Font);
	titleStyle.normal.textColor = Color.white;
	titleStyle.fontSize = 64;
	GUI.Label (Rect ((Screen.width / 2) - (Screen.width / 15), 8 * Screen.height / 10, Screen.width, Screen.height), PlayerMove.updatedTime, titleStyle);
}