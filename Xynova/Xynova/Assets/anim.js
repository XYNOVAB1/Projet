#pragma strict

var couleurEntrer : Color = Color.blue;
var couleurSortie : Color = Color.white;

function OnMouseEnter() {
	guiText.material.color = couleurEntrer;
}

function OnMouseExit() {
	guiText.material.color = couleurSortie;
}