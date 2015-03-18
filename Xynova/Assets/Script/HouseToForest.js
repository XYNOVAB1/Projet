var MyLevel : String;
var MyPlayer : GameObject;
var Destination : Transform;

function OnTriggerEnter(other : Collider)
{
	if (other == MyPlayer.collider)
	{
		Application.LoadLevel(MyLevel);
	}
}


function OnLevelWasLoaded()
{
	MyPlayer.transform.position = Destination.position;
}