using UnityEngine;
using System.Collections;

public class deplacement_X : MonoBehaviour {

	private int speed = 60;

	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0, 0);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}