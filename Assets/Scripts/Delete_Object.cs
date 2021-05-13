using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Object : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Ballon") {
			other.gameObject.SetActive (false);
		}
	}

}
