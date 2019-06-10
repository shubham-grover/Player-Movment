using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool GameHasEnded = false;
	public float DelayInRestart = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndGame () {
		if (GameHasEnded == false) {
			GameHasEnded = true;
			Debug.Log ("Game Over");
			//RestartGame ();  // Restart Game
			Invoke("RestartGame", DelayInRestart);
		}
	}

	public void RestartGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
