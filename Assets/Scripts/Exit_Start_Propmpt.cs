using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Start_Propmpt : MonoBehaviour {

	public GameObject Exit_Level_Objectives;
	public GameObject Level_Objectives;
	public GameObject panel_under_levelobjectives;
	 public bool click = false;
	// Use this for initialization
	void Start () {
		Exit_Level_Objectives.SetActive (true);
		Level_Objectives.SetActive (true);
		panel_under_levelobjectives.SetActive (true);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseUp()
	{
		click = true;
		Destroy (Exit_Level_Objectives);
		Destroy (Level_Objectives);
		Destroy (panel_under_levelobjectives);

	}
}
