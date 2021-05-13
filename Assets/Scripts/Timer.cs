using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text timerText;
	public float startTime ;
	public bool finished = false;



	// Use this for initialization
	void Start () {
		startTime = Time.time + 120f;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (finished)
			return;
		float t = startTime - Time.time;
	//	string minutes = ((int)t / 60).ToString ();
		string seconds = (t %120 ).ToString ("f0");
		timerText.text = seconds;
	}

	public void Finished()
	{
		
		finished = true;
		timerText.color = Color.yellow;
	}
}
