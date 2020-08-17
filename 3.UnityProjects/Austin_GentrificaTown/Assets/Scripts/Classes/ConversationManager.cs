//ConversationManager.cs
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ConversationManager : Singleton<ConversationManager> {

	//is there a conversation running?
	bool talking = false;

	//current line
	ConversationEntry currentConversationLine;

	//canvas group
	public CanvasGroup dialogueBox;

	//image
	public Image imageHolder;

	//text
	public Text textHolder;

	//make a private variable to hold a reference to the player
	private CharacterMovement thePlayer;

	//get the receiver
	//public MessagingClientReceiver messageReceiver;

	//ADDING --> reference to the speaker
	private static GameObject speaker;

	//ADDING --> set the speaker
	public static void SetSpeaker(string tag){
		Debug.Log ("in ConversationManager, SetSpeakerTag: " + tag);
		speaker = GameObject.FindWithTag(tag);	
	}

	//start the conversation
	public void StartConversation(Conversation dialogue){

		dialogueBox = GameObject.Find ("DialogueBox").GetComponent<CanvasGroup> ();
		imageHolder = GameObject.Find ("SpeakerImage").GetComponent<Image> ();
		textHolder = GameObject.Find ("DialogueText").GetComponent<Text> ();

		//**adding freeze player
		//in start, assign the name 'thePlayer' to the playemer movment script
		// CharacterMovement.cs
		thePlayer  = GameObject.Find("Player").GetComponent<CharacterMovement>();

		//start text display
		if(!talking){
			StartCoroutine(DisplayConversation(dialogue));
		}
	}

	//get Conversation object
	//loop through lines of dialogue
	//called from MessagingClientReceiver class
	IEnumerator DisplayConversation(Conversation dialogue){

		talking = true;

		//here is where the dialogue stars
		//player is allowed to move
		thePlayer.canMove = false;

		foreach (var conversationLine in dialogue.ConversationLines) {
			currentConversationLine = conversationLine;
			textHolder.text = currentConversationLine.ConversationText;
			imageHolder.sprite = currentConversationLine.DisplayPicture;
			yield return new WaitForSeconds (3);
		}

		talking = false;

		//here is where the dialogue is deactivated
		//player is allowed to move
		thePlayer.canMove = true;

	}	

	void OnGUI(){

		if (talking){
			dialogueBox.alpha = 1;
			dialogueBox.blocksRaycasts = true;

		}
		else {
			dialogueBox.alpha = 0;
			dialogueBox.blocksRaycasts = false;
		}
	}
}
