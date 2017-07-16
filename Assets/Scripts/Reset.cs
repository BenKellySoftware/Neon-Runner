using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	void OnTriggerEnter(Collider collision) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
