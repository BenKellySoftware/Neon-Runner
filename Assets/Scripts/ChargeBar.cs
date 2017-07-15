using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeBar : MonoBehaviour {

	public GameObject Player;


	// Use this for initialization
	void Start() {
    }
	
	// Update is called once per frame
	void Update () {
		float size = Player.GetComponent<CharacterMovement> ().energy - Player.GetComponent<CharacterMovement> ().charge;

		GetComponent<RectTransform>().sizeDelta = new Vector2(size * 10, 75);
//		if (Speed > 5) {
//			GetComponent<Renderer>().material.color = Color.cyan;
//		}
//		else {
//			GetComponent<Renderer>().material.color = Color.red;
//		}
	}
}