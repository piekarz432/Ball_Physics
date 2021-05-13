using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Object : MonoBehaviour {
	Vector3 screenPoint; 
	Vector3 offset;
	public GameObject[] rotation_graphic;

	[SerializeField]
	private Start_Ball str_ball;

	[SerializeField]
	private Restart_Level restart_level;




	void Start()
	{
		foreach (GameObject rotation in rotation_graphic) {
			rotation.SetActive (false);
		}
	}


	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position); 
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		foreach (GameObject rotation in rotation_graphic) {
			rotation.SetActive (true);
		}
		if (gameObject.tag == "Ballon") {
			this.gameObject.transform.localScale = new Vector3 (0.13f, 0.13f, 0.13f);
		} else {
			this.gameObject.transform.localScale = new Vector3 (0.0759127f, 0.0759127f, 0.0759127f);
		}

		if (str_ball.play == true) {
			restart_level.OnMouseUp ();
			
		}

	}

	void OnMouseDrag()
	{
		Vector3 cursorPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorPoint) + offset;
		transform.position = cursorPosition;
	}

	public void show_rotation_graphic()
	{
		foreach (GameObject rotation in rotation_graphic) {
			rotation.SetActive (false);
		}
	}


		
}
