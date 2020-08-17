// SprayPaintAudio.cs
// attaches to audio object
// uses a trigger colider to play audio


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import audio
using UnityEngine.Audio;

public class SprayPaintAudio : MonoBehaviour {

	//reference to the audio source
	public AudioSource sprayPaintSource;

	// Use this for initialization
	void Start () {

		//get the component
		sprayPaintSource = GetComponent<AudioSource>();

	}

	//get collision object
	void OnTriggerEnter2D(Collider2D collision){

		sprayPaintSource.Play ();

	}

	void OnColliderEnter2D(Collider2D collision){

		sprayPaintSource.Play ();

	}

	// Update is called once per frame
	void Update () {

	}
}
