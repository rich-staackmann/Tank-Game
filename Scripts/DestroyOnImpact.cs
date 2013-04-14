using UnityEngine;
using System.Collections;

public class DestroyOnImpact : MonoBehaviour {
	public GameObject fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// This destroy the bullet on impact, or after 15 seconds
	void Update () {
		Destroy(gameObject, 10);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Instantiate(fire, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
