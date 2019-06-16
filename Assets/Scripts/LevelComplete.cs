using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

	public GameManager Game_Manager;
	public Movement movement;

	void OnTriggerEnter() {
		Game_Manager.LevelComplete ();
		movement.enabled = false;
	}
}
