#pragma strict

function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Cube")
    {
        Application.LoadLevel("charge");
    }
    if(col.gameObject.name == "foret")
    {
        Application.LoadLevel("foret");
    }
}