static var speed : int = 3;
static var time : float;
static var updatedTime : String;
static var titleStyle : GUIStyle;
static var level : float;

//static var newSprite : Sprite;
//static var directionMoved : int; // 0 = north, 1 = east, 2 = south, 3 = west
//static var count : int;
     
function Start() {
	time = 0.0;
	updatedTime = "";
	//directionMoved = 0;
	//count = 0;
}	
  
function SpeedUp() {
	yield WaitForSeconds(5);
	speed = 3;
}
           
function Update () {
	if (speed == 4) {
		SpeedUp();
	}
	time += Time.deltaTime;
	
	var minutes = Mathf.FloorToInt(time / 60);
	var seconds = 0;
	var milliseconds = "";
	var index = -1;
	/*
	newSprite = Sprite();
		
	if (count == 1000000) {
		count = 0;
	}
		
	if (directionMoved == 0) { 
		newSprite = Resources.Load("player_stand_north", Sprite);
	} else if (directionMoved == 1) {
		newSprite = Resources.Load("player_stand_east", Sprite);
	} else if (directionMoved == 2) {
		newSprite = Resources.Load("player_stand_south", Sprite);
	} else {
		newSprite = Resources.Load("player_stand_west", Sprite);
	}	
	
	this.GetComponent(SpriteRenderer).sprite = newSprite;
	*/
		
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
	
	// newSprite = Sprite();
	
	if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
		// Debug.Log("UP");
		/*
		if (count % 27 == 1 || count % 27 == 2 || count % 27 == 3 || count % 27 == 4 || count % 27 == 5 || count % 27 == 6 || count % 27 == 7 || count % 27 == 8 || count % 27 == 9) {
			newSprite = Resources.Load("player_walk_one_north", Sprite);
		} else if (count % 27 == 10 || count % 27 == 11 || count % 27 == 12 || count % 27 == 13 || count % 27 == 14 || count % 27 == 15 || count % 27 == 16 || count % 27 == 17 || count % 27 == 18) {
			newSprite = Resources.Load("player_walk_two_north", Sprite);
		} else {
			newSprite = Resources.Load("player_stand_north", Sprite);
		}
		directionMoved = 0;
		this.GetComponent(SpriteRenderer).sprite = newSprite;
		*/
		transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);	
		
	}
	
	if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
		// Debug.Log("DOWN");
		/*
		if (count % 27 == 1 || count % 27 == 2 || count % 27 == 3 || count % 27 == 4 || count % 27 == 5 || count % 27 == 6 || count % 27 == 7 || count % 27 == 8 || count % 27 == 9) {
			newSprite = Resources.Load("player_walk_one_south", Sprite);
		}else if (count % 27 == 10 || count % 27 == 11 || count % 27 == 12 || count % 27 == 13 || count % 27 == 14 || count % 27 == 15 || count % 27 == 16 || count % 27 == 17 || count % 27 == 18) {
			newSprite = Resources.Load("player_walk_two_south", Sprite);
		} else {
			newSprite = Resources.Load("player_stand_south", Sprite);
		}
		directionMoved = 2;
		this.GetComponent(SpriteRenderer).sprite = newSprite;
		*/
		transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);	
		
	}
	
	if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
		// Debug.Log("LEFT");
		/*
		if (count % 27 == 1 || count % 27 == 2 || count % 27 == 3 || count % 27 == 4 || count % 27 == 5 || count % 27 == 6 || count % 27 == 7 || count % 27 == 8 || count % 27 == 9) {
			newSprite = Resources.Load("player_walk_one_west", Sprite);
		} else if (count % 27 == 10 || count % 27 == 11 || count % 27 == 12 || count % 27 == 13 || count % 27 == 14 || count % 27 == 15 || count % 27 == 16 || count % 27 == 17 || count % 27 == 18) {
			newSprite = Resources.Load("player_walk_two_west", Sprite);
		} else {
			newSprite = Resources.Load("player_stand_west", Sprite);
		}
		directionMoved = 3;
		this.GetComponent(SpriteRenderer).sprite = newSprite;
		*/
		transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);	
		
	}
	
	if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
		// Debug.Log("RIGHT");
		/*
		if (count % 27 == 1 || count % 27 == 2 || count % 27 == 3 || count % 27 == 4 || count % 27 == 5 || count % 27 == 6 || count % 27 == 7 || count % 27 == 8 || count % 27 == 9) {
			newSprite = Resources.Load("player_walk_one_east", Sprite);
		} else if (count % 27 == 10 || count % 27 == 11 || count % 27 == 12 || count % 27 == 13 || count % 27 == 14 || count % 27 == 15 || count % 27 == 16 || count % 27 == 17 || count % 27 == 18) {
			newSprite = Resources.Load("player_walk_two_east", Sprite);
		} else {
			newSprite = Resources.Load("player_stand_east", Sprite);
		}
		directionMoved = 1;
		this.GetComponent(SpriteRenderer).sprite = newSprite;
		*/
		transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);	
	}
	// count++;
}

function OnGUI () {
	titleStyle = new GUIStyle();
	titleStyle.font = Resources.Load("windows_command_prompt", Font);
	titleStyle.normal.textColor = Color.white;
	titleStyle.fontSize = 36;
	GUI.Label (Rect (10, 10, 500, 100), updatedTime, titleStyle);
}