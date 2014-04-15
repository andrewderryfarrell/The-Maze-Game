function Update() {
	if (Input.GetKey(KeyCode.Space)) {
		NextLevel.level = 1;
		Application.LoadLevel("Level1");
	}
}