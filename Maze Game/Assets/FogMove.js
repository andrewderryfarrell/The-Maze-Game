static var player : GameObject;
static var myTransform : Transform;
static var target : Transform;

function Update() {	
	player = GameObject.Find("Player");
	
	// Debug.Log(player.transform.position);
	
	myTransform = this.transform;
	
	target = player.transform;
	
	myTransform.position = target.position;
}