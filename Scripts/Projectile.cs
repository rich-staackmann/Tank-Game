using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed = 200;
	float velocity;
	Vector3 motionVec = new Vector3(0,1,1);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Time.deltaTime * speed * transform.forward;
	}
}
