static var speed : int = 3;
static var player : GameObject;
static var myTransform : Transform;
static var target : Transform;
static var count : int = 1;
static var zPos : float;

function SlowDown() {
	yield WaitForSeconds(5);
	speed = 3;
}

function Start() {
	zPos = transform.position.z;
}

function Update() {	
	if (speed == 2) {
		SlowDown();
	}

	player = GameObject.Find("Player");	
	
	// Debug.Log(player.transform.position);
	
	myTransform = this.transform;
	
	target = player.transform;
	
	var distance = Mathf.Sqrt(Mathf.Pow(myTransform.position.x - target.position.x, 2) + Mathf.Pow(myTransform.position.y - target.position.y, 2));
	
	// Debug.Log("distance = " + distance);
	
	if (distance < 0.30) {
		// Debug.Log(count);
		// count++;
		Application.LoadLevel("CaughtScreen");
	} 
	if (distance > 3.5) {
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
						   Random.rotation,
						   Time.deltaTime * speed); 
	
		myTransform.position += myTransform.forward * Time.deltaTime * speed;
		myTransform.position.z = zPos;
	} else {
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
						   Quaternion.LookRotation(target.position - myTransform.position), 
						   Time.deltaTime * speed); 
	
		myTransform.position += myTransform.forward * Time.deltaTime * speed;
	}
}

function OnCollisionEnter2D (collision : Collision2D) {
	// var relativePosition = this.transform.InverseTransformPoint(collision.transform.position);
	// Debug.Log("count = " + count);
	// count++;
}

// "UP"
// transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);

// "DOWN"
// transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);

// "LEFT"
// transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);

// "RIGHT"
// transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);