using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// This is to destroy the explosion particle effect
	//The effect is a free asset store effect and just stayed on the ground.
	//It was made in the older particle stystem and I couldn't figure out how to make it go away.
	void Update () {
		Destroy(gameObject, 2);
	}
}
