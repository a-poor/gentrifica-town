//SplashScreen.cs
//creates a splash screen for the game
//loads the first scene of gameplay
//often the first scene
//attaches to SplashScreen object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import scene management
using UnityEngine.SceneManagement;


public class SplashScreen : MonoBehaviour {


	//reference to the scene to load
	public string sceneToLoadName;

	//reference to a load time
	public int timeToLoad;


	// Use this for initialization
	void Start () {

		//call the NextScene() function
		Invoke ("NextScene", timeToLoad);

	}


	void NextScene(){

		SceneManager.LoadScene (sceneToLoadName);

	}

	// Update is called once per frame
	void Update () {

	}
}
