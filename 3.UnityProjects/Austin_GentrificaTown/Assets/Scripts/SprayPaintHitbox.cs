using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayPaintHitbox : MonoBehaviour {

	//Animator graffitiAnim;
	Animator graffitiSprayAnim;
	public GameObject sprayCloud;

	//find graffiti spray objects
	


	void Awake () {
		sprayCloud = GameObject.FindWithTag ("graffitiCloud");
		//graffitiAnim = (Animator)GetComponent (typeof(Animator));


		//graffitiSprayAnim = (Animator)GetComponent (typeof(Animator));
		graffitiSprayAnim = sprayCloud.GetComponent<Animator>();

		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		graffitiSprayAnim.SetTrigger ("isSpraying");





		//graffitiAnim.SetInteger ("Graffiti", 1);


	}
	void OnTriggerStay2D(Collider2D col){
		graffitiSprayAnim.SetTrigger ("isSpraying");


	}

	void OnTriggerExit2D(Collider2D col){




	}


}



