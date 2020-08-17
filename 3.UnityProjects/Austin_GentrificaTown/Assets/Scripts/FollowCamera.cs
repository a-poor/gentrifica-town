//FollowCamera.cs

using System.Collections;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	//distance from player to camera on x-axis
	public float xOffset = 0f;


	//distance from player to camera on y-axis
	public float yOffset = 0f;


	//referece to player transform (location)
	public Transform player;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void LateUpdate() {
		//last set of objects to update
		//final accounting function
		//set the x position camera to the play plus or minus an offset
		//set the y position of the camera to the camera y plus or minus an offset
		//accept the z position of the camera (woring in 2D)

		this.transform.position = new Vector3 (player.transform.position.x + xOffset, this.transform.position.y + yOffset, -10);



	}

}
