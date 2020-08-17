// LandlordAudio.cs
// attaches to audio object
// uses a trigger colider to play audio


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import audio
using UnityEngine.Audio;

public class LandlordAudio : MonoBehaviour {

	//reference to the audio source
	public AudioSource landlordSource;

	// Use this for initialization
	void Start () {

		//get the component
		landlordSource = GetComponent<AudioSource>();

	}

	//get collision object
	void OnTriggerEnter2D(Collider2D collision){

		landlordSource.Play ();

	}

	void OnColliderEnter2D(Collider2D collision){

		landlordSource.Play ();

	}

	// Update is called once per frame
	void Update () {

	}
}
