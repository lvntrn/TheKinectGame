using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour 
{

	public float moveSpeed = 10f;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveX, 0.0f, moveZ);
		//rb.velocity = movement * moveSpeed * Time.deltaTime;
		rb.AddForce ( movement * moveSpeed);
	}

}


//using UnityEngine;
//using System.Collections;
//
//public class PlayerController : MonoBehaviour {
//
//	public float speed;
//
//	private Rigidbody rb;
//
//	void Start ()
//	{
//		rb = GetComponent<Rigidbody>();
//	}
//
//	void FixedUpdate ()
//	{
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//
//		rb.AddForce (movement * speed);
//	}
//}