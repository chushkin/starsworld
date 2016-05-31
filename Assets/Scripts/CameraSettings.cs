using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Camera camera;

	private float lastHeiht = 0;

	void OnEnable()
	{
		if (!camera)
		{
			Debug.Log ("Camera is not set");
			enabled = false;			
		}
	}
	
	// Update is called once per frame
	void Update () {
	//	if (lastHeight != Screen.height)
	//	{
	//		lastHeight = Screen.height;
	//		camera.orthographicSize = lastHeight / 2;
	//	}
	}
}
