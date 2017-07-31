using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReplaySystem	 : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrames = new MyKeyFrame [bufferFrames];
	private Rigidbody rb;
	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		gameManager = GameObject.FindObjectOfType<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!gameManager.recording) {
			PlayBack ();
		} else
			Record ();
	}
	void PlayBack(){
		Debug.Log ("Entered PlayBack");
		rb.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		//print ("Reading frame " + frame);
		transform.position = keyFrames [frame].position;
		transform.rotation = keyFrames [frame].rotation;
	}
	void Record ()
	{
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		//print ("Write Frame " + frame);
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}
/// <summary>
/// A Structure for storing time, position, and rotation.
/// </summary>
public struct MyKeyFrame{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;
	public MyKeyFrame(float time, Vector3 pos, Quaternion rot){
		frameTime = time;
		position = pos;
		rotation = rot;

	}
}
