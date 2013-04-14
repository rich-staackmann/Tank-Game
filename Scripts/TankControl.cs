using UnityEngine;
using System.Collections;

public class TankControl : MonoBehaviour {
	public float speed = 25.0F;
	public float rotationSpeed = 50.0f;
	Vector3 groundNormal = Vector3.up;
	public float slopeLimit = 90.0F;
	public Texture2D crosshair;
	float rotHoriz;
	float forward;
	Vector3 velocity;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// If the terrain isn't too steep the this function checks the horizontal axis and rotates around the Y
	// Then it gets the vertical axis and translates in Z
	//It has an arcade feel, but that is what i was going for
	void Update () {
 	if(!tooSteep())
		{
			rotHoriz = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
			transform.Rotate(0, rotHoriz,0);
			
			forward = Input.GetAxis("Vertical") * speed;
			forward *= Time.deltaTime;
			velocity = new Vector3(0,0, forward);
			
			transform.Translate(velocity);
		}
	}
	//tooSteep is a basic check to keep the tank from climbing up hills, based on tank's x rotation
	bool tooSteep()
	{
		return (transform.rotation.eulerAngles.x >= slopeLimit);
	}
	//this code draws the crosshair based on the mouse position
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x - 64/2, Screen.height - Input.mousePosition.y - 64/2, 64, 64),crosshair);
	}
}
