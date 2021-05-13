using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_ball_4 : MonoBehaviour {

	public Rigidbody2D[] rgBody;
	public bool play = false;
	public Drag_Object_4 drag_Object_4;

	public void OnMouseUp()
	{
		
		Play ();

		Debug.Log ("Gra uruchomiona");
	}

	public void Play()
	{
		foreach (Rigidbody2D rigidbody in rgBody) {
			rigidbody.simulated = true;

		}
		play = true;
		drag_Object_4.Show_rotation ();

	}
}
