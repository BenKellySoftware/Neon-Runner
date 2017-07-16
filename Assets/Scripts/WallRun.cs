using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRun : MonoBehaviour {
	public int wallSide = 1;

	void OnTriggerEnter(Collider collision) {
		collision.gameObject.GetComponent<CharacterMovement>().wallRunning = true;
		collision.gameObject.GetComponent<CharacterMovement>().wallSide = wallSide;
		collision.gameObject.GetComponent<CharacterMovement>().ResetJump();
	}
	void OnTriggerExit(Collider collision) {
		collision.gameObject.GetComponent<CharacterMovement>().wallRunning = false;
		collision.gameObject.GetComponent<CharacterMovement>().wallSide = 0;
	}
}
