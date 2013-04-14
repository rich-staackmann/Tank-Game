using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	bool paused = false;
	public GUIStyle style;
	// Use this for initialization
	void Start () {
	
	}
	
	// This just detects when the p key is pressed and pauses the game through the
	//timescale function. I also draw a simple dui labal to display "Game Paused" 
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.P) && paused == false)
		{
			Time.timeScale = 0.0f;
			Screen.lockCursor = true;
			paused = true;
			return;
		}
		
		if(Input.GetKeyDown(KeyCode.P) && paused == true)
		{
			Time.timeScale = 1.0f;
			Screen.lockCursor = false;
			paused = false;
			return;
		}
	}
	
	void OnGUI()
	{
		if(paused == true)
		{
			 GUI.Label(new Rect(Screen.width/2 - 50, Screen.height/2 + 50, 100, 30), "Game Paused", style);
		}
	}
}
