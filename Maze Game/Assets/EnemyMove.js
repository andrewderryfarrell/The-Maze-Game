static var speed : int = 3;
static var player : GameObject;
static var myTransform : Transform;
static var target : Transform;

function Update() {	
	var number = parseInt(Random.Range(1, 5));
	// Debug.Log("Number: " + number);
	player = GameObject.Find("Player");
	
	// Debug.Log(player.transform.position);
	
	myTransform = this.transform;
	
	target = player.transform;
	
	myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
						   Quaternion.LookRotation(target.position - myTransform.position), 
						   Time.deltaTime * speed); 
	
	myTransform.position += myTransform.forward * Time.deltaTime * speed;
}

// "UP"
// transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);

// "DOWN"
// transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);

// "LEFT"
// transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);

// "RIGHT"
// transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);