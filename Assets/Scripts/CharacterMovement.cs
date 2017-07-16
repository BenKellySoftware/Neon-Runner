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
	public bool wallRunning;
	public int wallSide;

	void Start () {
		Cursor.visible = false;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (energy < 80 /*&& !wallRunning */) {
			energy += (Time.deltaTime * 200)/(energy + 25);
		}

		rb.useGravity = !wallRunning;

		float horizontalSpeed = Input.GetAxis ("Horizontal") * Time.deltaTime * 40;
		transform.Translate(wallRunning ? wallSide * Mathf.Clamp(wallSide  * horizontalSpeed, 0, 1) : horizontalSpeed, Time.deltaTime * energy * 2 * Mathf.Sin(-platformTilt), Time.deltaTime * energy * 2 * Mathf.Cos(platformTilt));
		transform.eulerAngles = new Vector3(0, Mathf.SmoothDampAngle(transform.eulerAngles.y, targetDirection, ref rotateSpeed, rotateTime), 0);

		if (Input.GetButton("Jump")) {
			if (energy - charge > 3) {
				charge += 18 * Time.deltaTime;
			}
		}	

		if (Input.GetButtonUp ("Jump")) {
			GetComponent<AudioSource>().Play();
			rb.AddForce (0, charge *  200, 0);
			if (wallRunning) {
				rb.AddForce (charge * 200 * wallSide, 0, 0);
			}
			energy -= charge;
			charge = 0;
		}
	}

	public void ResetJump() {
		Vector3 vel = rb.velocity;
		vel.y = 0;
		rb.velocity = vel;
	}
}