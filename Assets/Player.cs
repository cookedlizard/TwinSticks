using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	void Update(){

		if (CrossPlatformInputManager.GetAxis ("Vertical") > 0) {
			print ("Moving Forward");
		} else if (CrossPlatformInputManager.GetAxis ("Horizontal") < 0) {
			print ("Moving Left");
		} else if (CrossPlatformInputManager.GetAxis ("Vertical") < 0) {
			print ("Moving Backward");
		} else if (CrossPlatformInputManager.GetAxis ("Horizontal") > 0) {
			print ("Moving Right");
		} else if (CrossPlatformInputManager.GetAxis ("Jump") == 1) {
			print("Jumping");
		}
	}
}
