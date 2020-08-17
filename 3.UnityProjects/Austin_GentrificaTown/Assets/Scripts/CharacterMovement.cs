using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	private Rigidbody2D playerRigidbody2D;

	//private float movePlayerVertical;
	private bool isPlayerJumping;
	private float movePlayerHorizontal;
	private Vector2 movement;
	public int speed = 5;

	public Transform groundCheck;
	public LayerMask whatIsGround;

	public float jumpForce = 700f;


	private Animator playerAnim;

	public bool canMove;

	// For determining which way the player is currently facing. private bool facingRight;
	private bool facingRight;

	void Awake () {

		canMove = true;

		playerRigidbody2D = (Rigidbody2D)GetComponent (typeof(Rigidbody2D));


		playerAnim = (Animator)GetComponent (typeof(Animator));

	}

	// Update is called once per frame
	void Update () {

		if(!canMove){
			playerRigidbody2D.velocity = Vector2.zero;
			playerAnim.SetBool ("xMove", false);
			return;
		}


		movePlayerHorizontal = Input.GetAxis("Horizontal");


		//Move character by translation
		movement = new Vector2(movePlayerHorizontal, 0);
		playerRigidbody2D.velocity = movement * speed;


//		if (grounded && isPlayerJumping) {
//			Animator.SetBool ("Ground", false);
//			Rigidbody2D.AddForce(new Vector2 (0, jumpForce));
//
//		}




		//flips the character based on which direction its moving
		if (movePlayerHorizontal < 0 && !facingRight) { 
			Flip(); 
		} 
		else if (movePlayerHorizontal > 0 && facingRight) 
		{ 
			Flip(); 
		} 

		//sets the conditionals for animator
		if (movePlayerHorizontal > 0f || movePlayerHorizontal < 0f) {
			playerAnim.SetBool ("xMove", true);
		} else {
			playerAnim.SetBool ("xMove", false);
		}
			

	} 



	void FixedUpdate () {

		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//anim.SetBool("Ground", grounded);
		//Animator.SetBool ("Ground", grounded);

		

	}



	void Flip() { 
		// Switch the way the player is labeled as facing. 
		facingRight = !facingRight; 
		// Multiply the player's x local scale by -1. 
		Vector3 theScale = transform.localScale; 
		theScale.x *= -1; transform.localScale = theScale; 
	}
		





		
}