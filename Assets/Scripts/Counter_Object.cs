using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class Counter_Object : MonoBehaviour {

	public int counter;
	public Sprite[] number;
	public GameObject[] tab;
	public Image counter_max;
	public GameObject circle;



	// Use this for initialization
	void Start () {
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
				
		if (hit.collider.gameObject.name == "Shelf 001") {
					counter -= 1;
					for (int i = 0; i < 10; ++i) {
						if (counter == i) {
							counter_max.sprite = number [i];
							break;
						}
					}
					Instantiate (tab [0]);
					//Instantiate (tab [0]);
				} else {
					counter -= 1;
					for (int i = 0; i < 10; ++i) {
						if (counter == i) {
							counter_max.sprite = number [i];
							break;
						}
					}
				}

		if (counter == 0) {
			Destroy (counter_max);
			Destroy(GetComponent<Counter_Object>());
			Destroy (circle);
		}

		}

	}
}
		
