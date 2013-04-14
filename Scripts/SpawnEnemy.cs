using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	public int numEnemies;
	public GameObject enemy;
	
	//Just a simple script to spawn a number of enemy tanks at the start of the game
	void Start () 
	{
		for(int i = 0; i < numEnemies; i++)
		{
			Instantiate(enemy, new Vector3(880 + i, 0, 900 + i), new Quaternion(0,0,0,0));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
