using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Shoot : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Luckily the model I used had a separate object for the end of the main cannon.
	//This script instantiates a bullet at that point
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
				Instantiate(bullet, transform.position, transform.rotation);
				audio.Play();
		}
	}
}
