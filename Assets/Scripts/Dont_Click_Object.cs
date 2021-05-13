using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_Click_Object : MonoBehaviour {

	[SerializeField]
	private GameObject[] objects;

	[SerializeField]
	private Exit_Start_Propmpt e_s_prompt;
	// Use this for initialization
	void Start () {
		foreach(GameObject other in objects)
		{
			other.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		Show ();
	}

	void Show()
	{
		if (e_s_prompt.click == true) {
			foreach(GameObject other in objects)
			{
				other.SetActive (true);
				return;
			}
		}
	}
		
}
