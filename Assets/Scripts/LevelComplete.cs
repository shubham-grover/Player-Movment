using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public GameManager Game_Manager;
	public Movement movement;
	public float StartLevelDelay = 2f;

	void OnTriggerEnter() {
		Game_Manager.LevelComplete ();
		movement.enabled = false;
		Invoke("LoadNextLevel", StartLevelDelay);
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
