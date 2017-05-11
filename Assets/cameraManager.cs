using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour {

	public Camera[] cameras;
	public int cameraIndex;

	// Use this for initialization
	void Start () {

		cameraIndex = 0;
		for (int index = 1; index < cameras.Length; index++)
			cameras[index].gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Tab))
		{
			cameraIndex++;

			if (cameraIndex < cameras.Length) {

				cameras [cameraIndex - 1].gameObject.SetActive (false);
				cameras [cameraIndex].gameObject.SetActive (true);


			} else {

				cameras [cameraIndex - 1].gameObject.SetActive (false);
				cameraIndex = 0;
				cameras [cameraIndex].gameObject.SetActive (true);
			}

		}	
	}
}
