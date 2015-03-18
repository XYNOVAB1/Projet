using UnityEngine;
using System.Collections;

public class cam_Z : MonoBehaviour {
	
	private int speed = 240;
	
	void FixedUpdate() {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		
		Vector3 movement = new Vector3 (0, 0, moveHorizontal);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}