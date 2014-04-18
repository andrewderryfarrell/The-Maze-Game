static var player : GameObject;
static var myTransform : Transform;
static var target : Transform;

function Update() {	
	player = GameObject.Find("Player");
	
	// Debug.Log(player.transform.position);
	
	myTransform = this.transform;
	
	target = player.transform;
	
	// var distance = Vector3.Distance(myTransform.position, target.position);
	var distance = Mathf.Sqrt(Mathf.Pow(myTransform.position.x - target.position.x, 2) + Mathf.Pow(myTransform.position.y - target.position.y, 2));
	// Debug.Log("distance = " + distance);
	
	if (distance < 0.35) {
		// Debug.Log(count);
		// count++;
		EnemyMove.speed = 2;
		Destroy(this.gameObject);
	} 

}