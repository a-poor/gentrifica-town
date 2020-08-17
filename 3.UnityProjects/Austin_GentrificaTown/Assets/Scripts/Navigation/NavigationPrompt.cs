//NavigationPrompt.cs
//after GameState.cs is written
//adding -->fade scenes

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//adding fade scenes
using UnityEngine.UI;

public class NavigationPrompt : MonoBehaviour {

	public Vector3 startingPosition;

	//create containers
	public Image faderImage;
	public Animator faderAnim;

	//try to get the player to freeze when moving between scenes
	private CharacterMovement thePlayer;

	void Start(){

		faderAnim.SetBool ("Fade", false);
		faderImage = GameObject.FindWithTag ("Fader").GetComponent<Image> ();
		faderAnim = GameObject.FindWithTag ("Fader").GetComponent<Animator> ();
		thePlayer  = GameObject.Find("Player").GetComponent<CharacterMovement>();



	}


	void OnCollisionEnter2D(Collision2D col){
		//call the NavigationManager directly
		//it's a static class
		if(NavigationManager.CanNavigate(this.tag)){
			Debug.Log("attempting to exit via "+ tag);
			GameState.saveLastPosition=false;
			GameState.SetLastScenePosition(SceneManager.GetActiveScene().name, startingPosition);
			//NavigationManager.NavigateTo(this.tag);
			StartCoroutine(FadeScene());
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if(NavigationManager.CanNavigate(this.tag)){
			Debug.Log("attempting to exit via "+ tag);
			//NavigationManager.NavigateTo(this.tag);
			GameState.saveLastPosition=false;
			GameState.SetLastScenePosition(SceneManager.GetActiveScene().name, startingPosition);
			StartCoroutine(FadeScene());	

		}
	}

	IEnumerator FadeScene(){

		faderAnim.SetBool ("Fade", true);

		thePlayer.canMove = false;

		yield return new WaitUntil (() => faderImage.color.a ==1);

		NavigationManager.NavigateTo(this.tag);

	}

}