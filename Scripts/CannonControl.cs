using UnityEngine;
using System.Collections;

public class CannonControl : MonoBehaviour {
	public float elevateSpeed = 30f;
	float rot;
	Vector3 rotation;
	// Use this for initialization
	void Start () {
	
	}
	
	//This script is to control the elevation of the main cannon. 
	//My biggest issue was keeping the mouse in the window so that you can scroll forever 
	//and make the cannon do a 360 spin. I clamped it to the screen height and clamped the rotation as well.
	void Update () {
		//Debug.Log(Input.mousePosition.y);
		if(Input.mousePosition.y <= Screen.height && Input.mousePosition.y >= 0)
		{
			transform.Rotate(new Vector3(Input.GetAxis("Mouse Y")* -elevateSpeed*Time.deltaTime,0,0));
			
		}
		else if(Input.mousePosition.y > Screen.height)
		{
			transform.localEulerAngles = new Vector3(-20,0,0);
		}
		else
		{
			transform.localEulerAngles = new Vector3(0,0,0);
		}
	}
}
