#pragma strict

var minX = -10.0;
var maxX = 10.0;
var minZ = 5.0f;
var maxZ = 35.0f;
var minY = -2.0f;
var maxY = 7.0f;
var MaxEnnemis = 10;

function Start () {
	var number = Random.Range(1,MaxEnnemis); //Génère un nombre d'ennemis aléatoire

    for (var i = 0; i < number; i++) {
    	var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
    	go.name = 'Enemies';
    	go.AddComponent(Rigidbody);
    	go.AddComponent('ObjectPuller');
    	go.AddComponent('FreezeRotation');
    	/*go.AddComponent('FreezeXTranslation');*/
    	go.AddComponent('ZeroVelocity');
    	go.transform.position = Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ,maxZ));
    }
}