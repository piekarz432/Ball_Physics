using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Level : MonoBehaviour {

	[SerializeField]
	private GameObject ball;
	private Vector3 akt_pozycja;
	[SerializeField]
	private Start_Ball str_ball;
	[SerializeField]
	private Rigidbody2D rgBody;
	[SerializeField]
	private GameObject CardboardBox;
	private Vector3 akt_pozycja_box;
	[SerializeField]
	private Rigidbody2D rgbody_cardboardbox;
	private Quaternion rotation_cardboard_box;
	[SerializeField]
	private GameObject coin;
	[SerializeField]
	private Collect_Coins collect_coin;




	void Start()
	{
		akt_pozycja = ball.transform.position;
		akt_pozycja_box = CardboardBox.transform.position;
		rotation_cardboard_box = CardboardBox.transform.rotation;
	}

	public void OnMouseUp()
	{
		rgBody.velocity = Vector3.zero;
		rgBody.angularVelocity = 0f;
		ball.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		rgbody_cardboardbox.velocity = Vector3.zero;
		rgbody_cardboardbox.angularVelocity = 0f;
		ball.transform.position = akt_pozycja;
		coin.SetActive (true);
		collect_coin.counter_coin = 0;
		foreach (Rigidbody2D rigidbody in str_ball.rgBody) {
			rigidbody.simulated = false;
		}
		str_ball.play = false;
		CardboardBox.transform.position = akt_pozycja_box;
		CardboardBox.transform.rotation = rotation_cardboard_box;
	

	}
}
