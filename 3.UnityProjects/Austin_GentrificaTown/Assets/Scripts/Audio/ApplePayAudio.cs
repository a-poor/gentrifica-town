// ApplePayAudio.cs
// attaches to audio object
// uses a trigger colider to play audio


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import audio
using UnityEngine.Audio;

public class ApplePayAudio : MonoBehaviour {

	//reference to the audio source
	public AudioSource applePaySource;

	// Use this for initialization
	void Start () {

		//get the component
		applePaySource = GetComponent<AudioSource>();

	}

	//get collision object
	void OnTriggerEnter2D(Collider2D collision){

		applePaySource.Play ();

	}

	void OnColliderEnter2D(Collider2D collision){

		applePaySource.Play ();

	}

	// Update is called once per frame
	void Update () {

	}
}
