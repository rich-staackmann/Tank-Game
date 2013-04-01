using UnityEngine;
using System.Collections;

public class DestroyOnImpact : MonoBehaviour {
	public GameObject fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 15);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Instantiate(fire, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
