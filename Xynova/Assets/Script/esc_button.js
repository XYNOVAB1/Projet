#pragma strict

function Update() {
	if(Input.GetKey(KeyCode.Escape))
		Application.LoadLevel("menu");
}