using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	private float time;
	public Text timerLabel;
	private bool timerActivated;

	// wait for child messages
	void collision(string objectName) {

		if (objectName == "start")
			timerActivated = true;
		if (objectName == "finish")
			timerActivated = false;

	}
		
	// Update is called once per frame
	void Update () {

		if (timerActivated) {
			time += Time.deltaTime;
			timerLabel.text = Time.time.ToString ("0.0");
		}
		if (!timerActivated)
			time = 0;
		
	}
}
