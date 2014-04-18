static var player : GameObject;

function Update() {
	player = GameObject.Find("Cube");
	
	if (player == null) {
		Application.LoadLevel("NextLevelScreen");
	}
}