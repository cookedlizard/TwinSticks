using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {


	public bool recording = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print(CrossPlatformInputManager.GetButton("Fire1"));
		if (CrossPlatformInputManager.GetButton ("Fire1")) {
			recording = false;

		} else
			recording = true;	
		print (recording);
	}

	public void setRecording(){
		recording = true;
	}
	public void setPlayBack(){
		recording = false;
	}

}
