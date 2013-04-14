using UnityEngine;
using System.Collections;

public class WanderAI : MonoBehaviour {
	public GameObject[] node = new GameObject[4]; //nodes should have same Y coord as the pathfinding object, so it doesn't fly
	Vector3 target = Vector3.zero;
	Vector3 movementDir = Vector3.zero;
	Quaternion rotDir;
	int numNodes = 0;
	int i = 0;
	float speed = 0.05f;
	// Use this for initialization
	void Start () 
	{
		node[0] = GameObject.Find("Node1");
		node[1] = GameObject.Find("Node2");
		node[2] = GameObject.Find("Node3");
		node[3] = GameObject.Find("Node4");
		numNodes = 4;
		rotDir = Quaternion.LookRotation(node[0].transform.position - transform.position);
		movementDir = node[0].transform.position - transform.position; //finds the vector we need to move in
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.rotation = rotDir;
		transform.position += movementDir * speed * Time.deltaTime;
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		//iterate of node objects
		i = (i+1) % numNodes; //a fun bit of code that uses modulus to iterate for 0 to node[].length and back
		movementDir = node[i].transform.position - transform.position;
		rotDir = Quaternion.LookRotation(node[i].transform.position - transform.position);
	}
	
	
}
