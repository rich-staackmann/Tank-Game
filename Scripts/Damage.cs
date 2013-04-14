using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public int health = 5;
	public int damageTaken = 1;
	public GameObject smoke;
	bool onFire = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// This script is my bullet detection script.
	//It just checks for a collision with an object tagged "bullet"
	//then it decrements health
	void Update () {
		if(health == 0)
			Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.tag.Equals("Bullet"))
		{
			if(health >0)
				health -= damageTaken;
			else
				Destroy(gameObject);
		}
		
		if(health < 3 && !onFire)
		{
			Instantiate(smoke, transform.position, transform.rotation);
			smoke.transform.parent = gameObject.transform;
			onFire = true;
		}
	}
}
