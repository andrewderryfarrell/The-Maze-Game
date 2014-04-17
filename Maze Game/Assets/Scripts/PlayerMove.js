static var speed : int = 3;
static var time : float;
static var updatedTime : String;
static var titleStyle : GUIStyle;
     
function Start() {
	time = 0.0;
	updatedTime = "";
}	
     
function Update () {
	time += Time.deltaTime;
	
	var minutes = Mathf.FloorToInt(time / 60);
	var seconds = 0;
	var milliseconds = "";
	var index = -1;
		
	if (minutes > 0) {
		seconds = Mathf.Floor(time - minutes * 60);
		
		var newSeconds = seconds.ToString();
		
		if (newSeconds.Length == 1) {
		
			newSeconds = "0" + newSeconds;
		
		}	
			
		milliseconds = (time - minutes * 60).ToString();
		
		index = milliseconds.IndexOf(".");
		
		milliseconds = milliseconds.Substring(index + 1, 2);
		
		updatedTime = minutes + ":" + newSeconds + "." + milliseconds;		
		// Debug.Log(updatedTime);		
	} else {
		seconds = Mathf.FloorToInt(time);
		
		milliseconds = time.ToString();
		
		index = milliseconds.IndexOf(".");
		
		milliseconds = milliseconds.Substring(index + 1, 2);
		
		updatedTime = seconds + "." + milliseconds;
		// Debug.Log(updatedTime);
	}
	
	if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
		// Debug.Log("UP");
		transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
		// Debug.Log("DOWN");
		transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
		// Debug.Log("LEFT");
		transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
		// Debug.Log("RIGHT");
		transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);
	}		
}

function OnGUI () {
	titleStyle = new GUIStyle();
	titleStyle.font = Resources.Load("windows_command_prompt", Font);
	titleStyle.normal.textColor = Color.white;
	titleStyle.fontSize = 24;
	GUI.Label (Rect (10, 10, 500, 100), updatedTime, titleStyle);
}