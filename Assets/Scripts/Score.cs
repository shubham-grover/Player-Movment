using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform Player;
	public Text ScoreText;
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(Player.position.z);
		ScoreText.text = Player.position.z.ToString("0");
	}
}
