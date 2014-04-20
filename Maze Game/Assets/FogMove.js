static var player : GameObject;
static var myTransform : Transform;
static var target : Transform;

function Update() {	
	player = GameObject.Find("Player");
	
	// Debug.Log(player.transform.position);
	
	
	target = player.transform;
	
	transform.position.x = target.position.x;
	transform.position.y = target.position.y;
}