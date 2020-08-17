//MessagingClientReceiver.cs
using UnityEngine;
using System.Collections;

public class MessagingClientReceiver : MonoBehaviour{

	//ADDING --> 
	//variable to help trck the conversation list
	private Conversation dialogue;
	private int conversationIndexLandlord;
	private int conversationIndexMTAguy;
	private int conversationIndexApplePay;
	private int conversationIndexVlogger;
	private int conversationNumberLandlord;
	private int conversationNumberMTAguy;
	private int conversationNumberApplePay;
	private int conversationNumberVlogger;


	//ADDING --> 
	//reference to npc speaking
	//to track which conversation to play
	private static GameObject speaker;


	void Start(){
		MessagingManager.Instance.Subscribe(NPCTalk);

		//ADDING --> 
		//conversation count
		conversationIndexLandlord = 0;
		conversationNumberLandlord = 2;
		conversationIndexMTAguy = 0;
		conversationNumberMTAguy = 2;
		conversationIndexApplePay = 0;
		conversationNumberApplePay = 1;
		conversationIndexVlogger = 0;
		conversationNumberVlogger = 2;
	}


	//ADDING --> 
	//set the speaking npc
	public void SetSpeaker(string tag){
		//Debug.Log ("in MessagingClientReceiver, SetSpeaker: " + tag);
		speaker = GameObject.FindWithTag(tag);	
	}

	//ADDING --> 
	//get the speaking npc
	public GameObject GetSpeaker(){
		//Debug.Log ("in MessagingClientReceiver, GetSpeaker: " + speaker);
		return speaker;	
	}

	//ADDING --> 
	//changed the name of this function
	void NPCTalk(){
		
		//ADDING --> 
		//get the speaking npc
		GetSpeaker();
		if (speaker.gameObject.tag == "Landlord") {
			dialogue = GameObject.Find("Landlord").GetComponent<ConversationComponent> ().Conversations[conversationIndexLandlord];
			Debug.Log ("In NPCTalk, conversationIndexLandlord: " + conversationIndexLandlord);
			//ADDING --> 
			//increment the conversation number
			if (conversationIndexLandlord < conversationNumberLandlord-1) conversationIndexLandlord++;
			else if (conversationIndexLandlord >= conversationNumberLandlord) conversationIndexLandlord = 0;
			//Debug.Log ("conversationIndexShopkeep: " + conversationIndexShopkeep);
		}
		else if(speaker.gameObject.tag == "MTAguy"){
			dialogue = GameObject.Find("MTAguy").GetComponent<ConversationComponent> ().Conversations[conversationIndexMTAguy];
			Debug.Log ("In NPCTalk, conversationIndexMTAguy: " + conversationIndexMTAguy);
			//ADDING --> 
			//increment the conversation number
			if (conversationIndexMTAguy < conversationNumberMTAguy-1) conversationIndexMTAguy++;
			else if (conversationIndexMTAguy >= conversationNumberMTAguy) conversationIndexMTAguy = 0;
			//Debug.Log ("conversationIndexMayor: " + conversationIndexMayor);

		}
		else if(speaker.gameObject.tag == "ApplePay"){
			dialogue = GameObject.Find("ApplePay").GetComponent<ConversationComponent> ().Conversations[conversationIndexApplePay];
			Debug.Log ("In NPCTalk, conversationIndexApplePay: " + conversationIndexApplePay);
			//ADDING --> 
			//increment the conversation number
			if (conversationIndexApplePay < conversationNumberApplePay-1) conversationIndexApplePay++;
			else if (conversationIndexApplePay >= conversationNumberApplePay) conversationIndexApplePay = 0;
			//Debug.Log ("conversationIndexMayor: " + conversationIndexMayor);

		}
		else if(speaker.gameObject.tag == "Vlogger"){
			dialogue = GameObject.Find("Vlogger").GetComponent<ConversationComponent> ().Conversations[conversationIndexVlogger];
			Debug.Log ("In NPCTalk, conversationIndexVlogger: " + conversationIndexVlogger);
			//ADDING --> 
			//increment the conversation number
			if (conversationIndexVlogger < conversationNumberVlogger-1) conversationIndexVlogger++;
			else if (conversationIndexVlogger >= conversationNumberVlogger) conversationIndexVlogger = 0;
			//Debug.Log ("conversationIndexMayor: " + conversationIndexMayor);

		}
		//ADDING --> 
		//simplified call to ConversationManager
		ConversationManager.Instance.StartConversation (dialogue);
		return;
	}

	void OnDestroy(){
		if (MessagingManager.Instance != null){
			MessagingManager.Instance.UnSubscribe(NPCTalk);
		}
	}
}
