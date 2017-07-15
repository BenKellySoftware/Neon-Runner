using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBar : MonoBehaviour {

	public GameObject Player;


	// Use this for initialization
	void Start() {
		
    }
	
	// Update is called once per frame
	void Update () {
		float energy = Player.GetComponent<CharacterMovement>().energy;

		GetComponent<RectTransform>().sizeDelta = new Vector2(energy * 10, 75);
//		if (Speed > 5) {
//			GetComponent<Renderer>().material.color = Color.cyan;
//		}
//		else {
//			GetComponent<Renderer>().material.color = Color.red;
//		}
	}
}