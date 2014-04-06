static var speed : int = 5;

function Update () {
	
	var number = parseInt(Random.Range(1, 5));
	Debug.Log("Number: " + number);
	
	if (number == 1) {
		transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);
	} else if (number == 2) {
		transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);
	} else if (number == 3) {
		transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);
	} else {
		transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);
	}
}