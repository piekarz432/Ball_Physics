using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Level_4 : MonoBehaviour {
	public GameObject Panel_End_Level;
	[SerializeField]
	private bool[] nr_level;

	[SerializeField]
	private Collect_Coins collect_coin;

	[SerializeField]
	private Animator end_level_anim;

	[SerializeField]
	private Start_ball_4 str_ball_4;

	[SerializeField]
	private GameObject[] objects;
	// Use this for initialization
	void Start () {
		Panel_End_Level.SetActive (false);


	}

	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && collect_coin.counter_coin==1) {
			foreach (GameObject obiekt in objects) {
				Destroy (obiekt.GetComponent<Drag_Object_4> ());
			}
			Show_End_Level_Panel ();




			Debug.Log ("Koniec levelu");

		}

	}

	public void Show_End_Level_Panel()
	{
		StartCoroutine(End_level());
		if (nr_level [1] == true) {
			PlayerPrefs.SetInt ("NextLevel", 1);
			return;
		}
		if (nr_level [2] == true) {
			PlayerPrefs.SetInt ("NextLevel2", 1);
			return;
		}

		if (nr_level [3] == true) {
			PlayerPrefs.SetInt ("NextLevel3", 1);
			return;
		}

		if (nr_level [4] == true) {
			PlayerPrefs.SetInt ("NextLevel4", 1);
			return;
		}

	}

	IEnumerator End_level()
	{
		yield return new WaitForSeconds (0.5f);
		Panel_End_Level.SetActive (true);
		foreach (Rigidbody2D rgbody in str_ball_4.rgBody) {
			rgbody.simulated = false;
		}

		end_level_anim.Play ("Level_Complete");
	}
}
