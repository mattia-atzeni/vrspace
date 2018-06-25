using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour {
	public Camera zoomcamerar;
	public Camera zoomcameral;
	private float original;
	
	// Use this for initialization
	void Start () {
		//zoom_flag = false;
		original = zoomcamerar.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			
			zoomcamerar.fieldOfView = 30;
			zoomcameral.fieldOfView = 30;
			
			
		}
		
		else {
			if (Input.GetKeyUp (KeyCode.Z)) {
				
				zoomcamerar.fieldOfView = 129.8719f;
				zoomcameral.fieldOfView = 129.8719f;
				
				
			}
			
		}
		
		
		
		
	}
}
