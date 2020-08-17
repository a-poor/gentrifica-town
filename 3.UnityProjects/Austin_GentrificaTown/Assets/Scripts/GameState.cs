//GameState.cs
//a static class
//holds overall game settings


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState {

	public static Player CurrentPlayer = ScriptableObject.CreateInstance<Player>();
	public static Dictionary<string, Vector3> LastScenePositions = new Dictionary<string, Vector3>();

	//GAME STATES
	//set in BattleManager.cs, function RunAway();
	//checked in RandomBattle.cs, function OnTriggerEnter2D();
	public static bool justExitedBattle;

	//set in MapPosition.cs, function OnDestroy().
	public static bool saveLastPosition = true;

	//set in NavigationPrompt.cs, OnCollisionEnter2D();
	//set in NavigationPrompt.cs, OnTriggerEnter2D();
	public static Vector3 startingPosition;

	public static Vector3 GetLastScenePosition(string sceneName){
		if (GameState.LastScenePositions.ContainsKey(sceneName)){
			var lastPos = GameState.LastScenePositions[sceneName];
			return lastPos;
		}
		else{
			return Vector3.zero;
		}
	}

	public static void SetLastScenePosition(string sceneName, Vector3 position){
		if (GameState.LastScenePositions.ContainsKey(sceneName)){
			GameState.LastScenePositions[sceneName] = position;
		}
		else {
			GameState.LastScenePositions.Add(sceneName, position);
		}
	}


}
