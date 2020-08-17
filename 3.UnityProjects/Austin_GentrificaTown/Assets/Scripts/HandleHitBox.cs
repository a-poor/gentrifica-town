//HandleHitBox.cs
//attach to player object
//capture trigger collisions
//and take action

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHitBox : MonoBehaviour {

	Animator playerAnim;


	void Awake(){

		playerAnim = (Animator)GetComponent (typeof(Animator));



	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("trigger enter");
		if (col.gameObject.tag == "playerCheckPhone") {
			Debug.Log ("congratulations, you collided");
			playerAnim.SetBool ("lookAtPhone", true);
		}
		if (col.gameObject.tag == "playerJump") {
			Debug.Log ("congratulations, you collided");
			playerAnim.SetBool ("isJumping", true);
		}
	}

	void OnTriggerStay2D(Collider2D col){
		//Debug.Log ("trigger continues");
		if (col.gameObject.tag == "playerCheckPhone") {
			//Debug.Log ("collision on door continues");
			playerAnim.SetBool ("lookAtPhone", false);
			playerAnim.SetBool ("phoneIdle", true);

		}
		if (col.gameObject.tag == "playerJump") {
			//Debug.Log ("collision on door continues");
			playerAnim.SetBool ("isJumping", true);

		}


	}

	void OnTriggerExit2D(Collider2D col){
		Debug.Log ("trigger exit");
		if (col.gameObject.tag == "playerCheckPhone") {
			Debug.Log ("now leaving, your collision");
			Destroy (col.gameObject);
			playerAnim.SetBool ("lookAtPhone", false);
			playerAnim.SetBool ("phoneIdle", false);
			playerAnim.SetBool ("phoneDown", true);

		}
		if (col.gameObject.tag == "playerJump") {
			Debug.Log ("now leaving, your collision");
			Destroy (col.gameObject);
			playerAnim.SetBool ("isJumping", false);

		}
	}
}
