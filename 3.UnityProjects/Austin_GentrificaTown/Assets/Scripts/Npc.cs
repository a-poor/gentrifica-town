//Npc.cs
//although we have an 'Entity' template
//that script is not a component class
//this file provides component ability for npcs
//by inheriting from MonoBehavior

using UnityEngine;

public class Npc : MonoBehaviour {

	public string Name;
	public int Age;
	public string Faction;
	public string Occupation;
	public int Level;
}

