using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Movement movement;

	void OnCollisionEnter(Collision CollisionInfo)  // Function for collision detection and further corresponding action
	{
		//if (CollisionInfo.GetComponent<Collider>().tag != "Surface")
		if (CollisionInfo.collider.tag != "Surface")
		{	
			//Debug.Log ("We hit - " + CollisionInfo.GetComponent<Collider>().name);
			Debug.Log ("We hit - " + CollisionInfo.collider.name);
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
