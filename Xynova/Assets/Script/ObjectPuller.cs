using UnityEngine;
using System.Collections;

public class ObjectPuller : MonoBehaviour
{
	public GameObject attractedTo;
	public float strengthOfAttraction = 5.0f;
	void Start ()
	{
	}
	void FixedUpdate ()
	{
		attractedTo = GameObject.Find ("Aïx");
		Vector3 direction = attractedTo.transform.position - transform.position;
		gameObject.rigidbody.AddForce (strengthOfAttraction * direction);
	}
}