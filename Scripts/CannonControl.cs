using UnityEngine;
using System.Collections;

public class CannonControl : MonoBehaviour {
	public float elevateSpeed = 30f;
	float rot;
	Vector3 rotation;
	// Use this for initialization
	void Start () {
	
	}
	
	
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
