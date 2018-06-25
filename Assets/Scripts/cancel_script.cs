using UnityEngine;
using System.Collections;

public class cancel_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//display_text.password_text = "1";

	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0)){
		
			display_text.password_text = "";
			display_text.max_cifre = 0;
				
			}
	
			
	
	}
}
