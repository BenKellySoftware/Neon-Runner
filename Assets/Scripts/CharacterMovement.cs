using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	private Rigidbody rb;
	public float energy = 0;
	public float charge = 0;

	public float targetDirection;
	public float platformTilt;
	private float rotateSpeed;
	public float rotateTime;
	public Vector3 forward;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (energy < 80) {
			energy += (Time.deltaTime * 100)/(energy + 25);
		}
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 20, Time.deltaTime * energy * 2 * Mathf.Sin(-platformTilt), Time.deltaTime * energy * 2 * Mathf.Cos(platformTilt));
		transform.eulerAngles = new Vector3(0, Mathf.SmoothDampAngle(transform.eulerAngles.y, targetDirection, ref rotateSpeed, rotateTime), 0);

		if (Input.GetButton("Jump")) {
			if (energy - charge > 3) {
				charge += 0.3f;
			}
		}

		if (Input.GetButtonUp ("Jump")) {
			GetComponent<AudioSource>().Play();
			rb.AddForce (0, charge *  100, 0);
			energy -= charge;
			charge = 0;
		}

	}
}