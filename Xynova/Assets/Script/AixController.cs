using UnityEngine;
using System.Collections;

public class AixController : MonoBehaviour {
	
	public float speedVertical = 300;
	public float speedHorizontal = 300;
	public Animator animForward;
	public Animator animBack;
	public Animator animLeft;
	public Animator animRight;

	void Start() {
		animForward.GetComponent<Animator> ();
		animBack.GetComponent<Animator> ();
		animLeft.GetComponent<Animator> ();
		animRight.GetComponent<Animator> ();
	}
	
	void Update() {
		
		float moveVertical = Input.GetAxis ("Vertical");		
		
		Vector3 movement = new Vector3 (0, moveVertical, 0);
		rigidbody.AddForce (movement * speedVertical * Time.deltaTime);



		float moveHorizontal = Input.GetAxis ("Horizontal");
		
		Vector3 movement2 = new Vector3 (0, 0, moveHorizontal);
		rigidbody.AddForce (movement2 * speedHorizontal * Time.deltaTime);


		if (moveVertical < 0) {
			animForward.SetFloat ("speed", Mathf.Abs (moveVertical));
		}
		if (moveVertical > 0) {
			animBack.SetFloat ("speed3", Mathf.Abs (moveVertical));
		}
		if (moveHorizontal > 0) {
			animRight.SetFloat ("speed2", Mathf.Abs (moveHorizontal));
		}
		if (moveHorizontal < 0) {
			animLeft.SetFloat ("speed4", Mathf.Abs (moveHorizontal));
		}

	}
}