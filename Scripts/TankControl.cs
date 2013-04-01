using UnityEngine;
using System.Collections;

public class TankControl : MonoBehaviour {
	public float speed = 25.0F;
	public float rotationSpeed = 50.0f;
	Vector3 groundNormal = Vector3.up;
	public float slopeLimit = 90.0F;
	public Texture2D crosshair;
	float rotHoriz;
	float rotLeft;
	float rotRight;
	float forward;
	float back;
	Vector3 velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
 	if(!tooSteep())
		{
			/*if (Input.GetKey(KeyCode.W))
			{
            		//transform.Translate(new Vector3(0,0,speed*Time.deltaTime));
				newPos = transform.position;
				newPos.z += speed * Time.deltaTime;
				transform.position = newPos;
			}
    		if (Input.GetKey(KeyCode.S))
			{
            		//transform.Translate(new Vector3(0,0,-speed*Time.deltaTime));
				newPos = transform.position;
				newPos.z += -speed * Time.deltaTime;
				transform.position = newPos;
			}
			if (Input.GetKey(KeyCode.A))
			{
            		transform.Rotate(new Vector3(0,-45*Time.deltaTime,0));
				
			}
		
    		if (Input.GetKey(KeyCode.D))
			{
            		transform.Rotate(new Vector3(0,45*Time.deltaTime,0));
				
			}
		} 
		else //TODO try to smooth this out...maybe calculate a normal and apply force along that
		{
			transform.Translate(new Vector3(0,0,-speed)*Time.deltaTime);
		} */
			rotHoriz = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
			transform.Rotate(0, rotHoriz,0);
			
			forward = Input.GetAxis("Vertical") * speed;
			//Debug.Log(forward);
			forward *= Time.deltaTime;
			velocity = new Vector3(0,0, forward);
			//velocity = transform.rotation * velocity;
			transform.Translate(velocity);
		}
	}
	bool tooSteep()
	{
		return (transform.rotation.eulerAngles.x >= slopeLimit);
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x - 64/2, Screen.height - Input.mousePosition.y - 64/2, 64, 64),crosshair);
	}
}
