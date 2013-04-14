using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour {
	public float turretSpeed = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// This rotates the turret around the Y axis based on the mouse
	//Biggest issue is keeping the mouse/crosshair aligned with the turret
	void Update () {
	if (Input.mousePosition.x <= Screen.width && Input.mousePosition.x >=0)
		{
           transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")* turretSpeed*Time.deltaTime,0));
		}
    else if(Input.mousePosition.x > Screen.width)
		{
			transform.localEulerAngles = new Vector3(0,20,0);
		}
	else
			transform.localEulerAngles = new Vector3(0,-20,0);
	}
}
