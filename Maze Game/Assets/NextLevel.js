static var level : int = 1;

function Start() {
	GoToNextLevel();
}

function GoToNextLevel() {
	yield WaitForSeconds(5);
	level++;
	Application.LoadLevel("Level" + level);	
}