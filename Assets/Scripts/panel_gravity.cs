using UnityEngine;
using System.Collections;

public class panel_gravity : MonoBehaviour {

	private GameObject panel;
	private GameObject player;



	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		panel = GameObject.FindGameObjectWithTag ("Panel");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player){
			//panel.rigidbody.useGravity = true;
			//panel.transform.Translate(-1, 1, 0);
			panel.animation.Play("Panel_animation");
			Destroy(this.gameObject);
		}

		
		
	}


}
