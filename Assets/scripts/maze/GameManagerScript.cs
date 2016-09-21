using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour  {

	public Text coinsLeft;

	public int coinCount = 0;
	public int scoreCount = 0;

	void Start() {
		
	}

	void Update() {
		UpdateUI ();
	}

	public void UpdateUI() {
		coinsLeft.text = "Score: " + scoreCount.ToString ();
	}

}
