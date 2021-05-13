using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Ball : MonoBehaviour {

	public Rigidbody2D[] rgBody;
	public Drag_Object d0bject;
	public bool play = false;

	public void OnMouseUp()
	{
		Play ();
		play = true;
		d0bject.show_rotation_graphic ();
		Debug.Log ("Gra uruchomiona");
	}

	public void Play()
	{
		foreach (Rigidbody2D rigidbody in rgBody) {
			rigidbody.simulated = true;
		}
	}
}
