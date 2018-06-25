using UnityEngine;
using System.Collections;

public class ValvePickUp : MonoBehaviour {

	private GameObject player;
	private GameObject valve;
	private GameObject text_valve;
	private playerInventory playerInventory;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

		valve = GameObject.FindGameObjectWithTag ("valve");
		playerInventory = player.GetComponent <playerInventory>();

		text_valve = GameObject.FindGameObjectWithTag ("text_pick_up_valve");
		//text_valve.SetActive (false);
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			text_valve.SetActive (true);
		}
		
		
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			text_valve.SetActive (false);
		}
	}

	void OnTriggerStay (Collider other){
				if (other.gameObject == player) {
						if (Input.GetKeyDown (KeyCode.R)) {
								valve.SetActive (false);
								text_valve.SetActive (false);
								playerInventory.HasValve = true;
						}
				}
		}


}
