using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_Coins : MonoBehaviour {
	[HideInInspector]
	public int counter_coin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			this.gameObject.SetActive (false);
			counter_coin += 1;
			Debug.Log (counter_coin);
		}
	}
}
