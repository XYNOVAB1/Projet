using UnityEngine;
using System.Collections;

public class cam_Y : MonoBehaviour {
	
	private int speed = 480;
	
	void FixedUpdate() {
		
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (0, moveVertical, 0);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}