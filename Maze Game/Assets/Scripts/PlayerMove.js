static var speed : int = 3;
     
function Update () {
			
	// Debug.Log(transform.position);	
		
	// Debug.Log("HERE");
	if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
		// Debug.Log("UP");
		transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
		// Debug.Log("DOWN");
		transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
		// Debug.Log("LEFT");
		transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);
	} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
		// Debug.Log("RIGHT");
		transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);
	}		
}