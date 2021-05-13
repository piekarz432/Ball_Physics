using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Level : MonoBehaviour {

	public GameObject[] levels_unlock;
	public GameObject[] levels_block;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Unlock_Levels ();
	}


	void Unlock_Levels()
	{
		if (PlayerPrefs.GetInt ("NextLevel") == 1) {
			levels_unlock [1].SetActive (true);
			levels_block [1].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("NextLevel2") == 1) {
			levels_unlock [2].SetActive (true);
			levels_block [2].SetActive (false);
		}

		if (PlayerPrefs.GetInt ("NextLevel3") == 1) {
			levels_unlock [3].SetActive (true);
			levels_block [3].SetActive (false);
		}
	}
}
