using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider collision) {
//		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		player.GetComponent<CharacterMovement>().Reset();
	}
}
