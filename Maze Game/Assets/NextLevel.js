static var level : int = 1;

function Update() {
	if (Input.GetKeyDown(KeyCode.Space)) {
		level++;
		Application.LoadLevel("Level" + level);	
	}
}