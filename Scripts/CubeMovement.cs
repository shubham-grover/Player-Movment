using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	// Use this for initialization\
	public float speed;

	public Rigidbody Rigid;
	void Start () {
		//Debug.Log ("Hello");
		Rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//Rigid.AddForce (0, 0, 1000)*Time.deltaTime;
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		Rigid.AddForce (movement * speed);
	}


}
