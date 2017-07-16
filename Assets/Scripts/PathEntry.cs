using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEntry : MonoBehaviour {
	public float targetDirection;
	public float platformTilt;
	public float rotateTime = 0.5f;

	void OnTriggerEnter(Collider collision) {
		collision.gameObject.GetComponent<CharacterMovement>().targetDirection = targetDirection;
		collision.gameObject.GetComponent<CharacterMovement>().platformTilt = Mathf.Deg2Rad * platformTilt;
		collision.gameObject.GetComponent<CharacterMovement>().rotateTime = rotateTime;
	}
	void OnTriggerExit(Collider collision) {
//		collision.gameObject.GetComponent<CharacterMovement>().targetDirection = 0;
//		collision.gameObject.GetComponent<CharacterMovement>().rotateTime = 2;
		collision.gameObject.GetComponent<CharacterMovement>().platformTilt = 0;
	}
}
