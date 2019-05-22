/* 
 * <Summary>This Code is developed/Used to move and object and to work on certain functionalities</Summary>
 * <Created By>Shubham Grover</Created By> 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	public Rigidbody Rb;

    //public Movement movement = new Movement();

	public float ForwardForce = 2000f;
	public float SidewaysForce = 1000f;
	void Start () {  // Called at the starting only
		Debug.Log ("Hello Player");
		//Rb.useGravity = false;
		//Rb.AddForce (0, 500, 500 * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		//Rb.AddForce (0, 400 * Time.deltaTime, 500 * Time.deltaTime);
		Rb.AddForce (0, 0, ForwardForce * Time.deltaTime);

		if (Input.GetKey ("d")) {
			Rb.AddForce (SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		} 
		else if (Input.GetKey ("a")) {
			Rb.AddForce (-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}	
	}

	/*	
	 * void OnCollisionEnter(Collision CollisionInfo)  // Function for collision detection and further corresponding action
		{		
			if (CollisionInfo.collider.tag != "Surface") {
				Debug.Log ("We hit - " + CollisionInfo.collider.name);
				movement.enabled = false;
			}
		}

	*/
}
