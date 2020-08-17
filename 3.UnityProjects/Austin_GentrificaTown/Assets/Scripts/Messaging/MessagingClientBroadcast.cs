//MessagingClientBroadcast.cs
using UnityEngine;
using System.Collections;


public class MessagingClientBroadcast : MonoBehaviour {


	public void OnCollisionEnter2D(Collision2D col){
		MessagingManager.Instance.Broadcast();
	}
		
	public void OnTriggerEnter2D(Collider2D col){
		//added for dialogue flags
		//reference to the receiver
		MessagingClientReceiver messageReceiver = GetComponent<MessagingClientReceiver> ();
		//added for dialogue flags
		//get the collisiono npc
		//remember, these npc are 'tagged' in the inspector
		if(gameObject.tag == "Landlord"){
			//Debug.Log ("Landlord");
			//added for dialogue flags
			//set the speaker in two places
			//ConversationManager and messageReceiver
			ConversationManager.SetSpeaker("Landlord");
			messageReceiver.SetSpeaker("Landlord");
		}
		if(gameObject.tag == "MTAguy"){
			//Debug.Log ("MTAguy");
			//added for dialogue flags
			//set the speaker in two places
			//ConversationManager and messageReceiver
			ConversationManager.SetSpeaker("MTAguy");
			messageReceiver.SetSpeaker("MTAguy");		
		}
		if (gameObject.tag == "ApplePay") {
			//Debug.Log ("Landlord");
			//added for dialogue flags
			//set the speaker in two places
			//ConversationManager and messageReceiver
			ConversationManager.SetSpeaker ("ApplePay");
			messageReceiver.SetSpeaker ("ApplePay");
		}
		if (gameObject.tag == "Vlogger") {
			//Debug.Log ("Landlord");
			//added for dialogue flags
			//set the speaker in two places
			//ConversationManager and messageReceiver
			ConversationManager.SetSpeaker ("Vlogger");
			messageReceiver.SetSpeaker ("Vlogger");
		}
		//conversationManager.SetNPC("MTAguy");
		MessagingManager.Instance.Broadcast();


	}

}