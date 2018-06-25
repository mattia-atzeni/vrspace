using UnityEngine;
using System.Collections;

public class wrong_valve_pick_up : MonoBehaviour {

	private GameObject player;
	private GameObject wrong_valve;
	private GameObject text_wrong_valve;
	private playerInventory playerInventory;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		
		wrong_valve = GameObject.FindGameObjectWithTag ("wrong_valve");
		playerInventory = player.GetComponent <playerInventory>();
		
		text_wrong_valve = GameObject.FindGameObjectWithTag ("text_pick_up_wrong_valve");
		//text_wrong_valve.SetActive (false);
		
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			text_wrong_valve.SetActive (true);
		}
		
		
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			text_wrong_valve.SetActive (false);
		}
	}
	
	void OnTriggerStay (Collider other){
		if (other.gameObject == player) {
			if (Input.GetKeyDown (KeyCode.R)) {
				wrong_valve.SetActive (false);
				text_wrong_valve.SetActive (false);
				playerInventory.HasWrongValve = true;
			}
		}
	}

}
