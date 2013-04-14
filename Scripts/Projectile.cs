using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed = 200;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Just a simple translation to move the bullet through the air.
	//Gravity takes care of the rest
	void Update () {
		transform.position += Time.deltaTime * speed * transform.forward;
	}
}
