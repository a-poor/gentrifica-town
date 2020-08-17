//KeepAround.cs
//prevents an object from being destroyed on load
//attaches to game object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAround : MonoBehaviour {

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (gameObject);

	}


}