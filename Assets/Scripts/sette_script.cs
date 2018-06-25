using UnityEngine;
using System.Collections;

public class sette_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//display_text.password_text = "1";

	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0))
				if (display_text.max_cifre < 4) {
				display_text.password_text = display_text.password_text+"7";
			display_text.max_cifre = display_text.max_cifre +1;
				
			}
	
			
	
	}
}
