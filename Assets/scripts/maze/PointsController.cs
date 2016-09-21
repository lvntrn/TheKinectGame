using UnityEngine;
using System.Collections;

public class PointsController : MonoBehaviour {

	private float rotationSpeed = 2f;
	GameManagerScript gameManager;

	void Awake() {
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
		gameManager.coinCount++;
	}

	void Start() {
		
	}

	void Update () {
		transform.Rotate (Vector3.up * rotationSpeed);
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "Player") {
			Destroy (gameObject);
			gameManager.coinCount--;
			gameManager.scoreCount += 10;
			//adding Score, etc.
		}
	}
}