#pragma strict

function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Cube")
    {
        Application.LoadLevel("charge");
    }
}