using UnityEngine;
using System.Collections;

public class deplacement_Y : MonoBehaviour {
	
	private int speed = 120;
	
	void FixedUpdate() {

		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (0, moveVertical, 0);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}