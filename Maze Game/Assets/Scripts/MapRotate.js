static var angle : float;

function Update () {
	transform.Rotate(0,0,6.0*2*Time.deltaTime);
	angle = transform.eulerAngles.z;
}