//MapPosition.cs
//loads player's last map position
//saves player's last map position
//attaches to the Player prefab

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapPosition : MonoBehaviour {

	void Awake(){
		var lastPosition = GameState.GetLastScenePosition(SceneManager.GetActiveScene().name);
		if (lastPosition != Vector3.zero){
			transform.position = lastPosition;
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnDestroy(){
		if (GameState.saveLastPosition) {
			GameState.SetLastScenePosition (SceneManager.GetActiveScene ().name, transform.position);
		}
	}
}