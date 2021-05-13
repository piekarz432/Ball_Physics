using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public GameObject[] Buttons;
	public GameObject[] Objects_show;


	public void returnMenu()
	{
		foreach (GameObject button in Buttons) {
			button.SetActive (false);
		}

		foreach (GameObject objects in Objects_show) {
			objects.SetActive (true);
		}


	}

	public void showLevel()
	{
		foreach (GameObject button in Buttons) {
			button.SetActive (true);
		}

		foreach (GameObject objects in Objects_show) {
			objects.SetActive (false);
		}

		PlayerPrefs.SetInt ("Play", 1);

		//PlayerPrefs.DeleteAll ();
	}
}
