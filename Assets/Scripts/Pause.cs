using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public Animator anim;
	private bool click;
	private bool tmp=false;
	private bool one_click=true;
	public Start_Ball str_ball;
	public GameObject panel_under_Pause;


	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void OnMouseUp ()
	{
		
		if (one_click) {
			anim.SetTrigger ("key");
			panel_under_Pause.SetActive (true);

			if (str_ball.play) {
				foreach (Rigidbody2D rigidbody in str_ball.rgBody) {
					rigidbody.simulated = false;
				}

			}


		}

		if (tmp) {
			anim.SetTrigger ("key");
			panel_under_Pause.SetActive (true);
			if (str_ball.play) {
				foreach (Rigidbody2D rigidbody in str_ball.rgBody) {
					rigidbody.simulated = false;
				}
			}

			click = false;
			tmp = false;
		}
		if (click) {
			anim.SetTrigger ("keyBack");
			panel_under_Pause.SetActive (false);
			if (str_ball.play) {
				foreach (Rigidbody2D rigidbody in str_ball.rgBody) {
					rigidbody.simulated = true;
				}
			}
			tmp = true;
		}
			click = true;
		    one_click = false;
	}
}

