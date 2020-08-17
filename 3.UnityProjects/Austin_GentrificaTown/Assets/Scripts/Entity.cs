//Entity.cs
using System.Collections;
using UnityEngine;

public class Entity : ScriptableObject {

	//declare properties
	public string characterName;
	public int age;
	public string faction;
	public string occupation;
	public int level;
	public int health;
	public int strength;
	public int magic;
	public int defense;
	public int speed;
	public int damage;
	public int armor;
	public int noOfAttacks;
	public string weapon;
	public Vector2 position;

	public void TakeDamage(int Amount){
		health = health - Mathf.Clamp((Amount-armor),0,int.MaxValue);
	}

	public void Attack(Entity Entity){
		Entity.TakeDamage (strength);
	}
}
