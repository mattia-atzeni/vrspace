using UnityEngine;
using System.Collections;

public class cable_pickup : MonoBehaviour {

	private GameObject player;
	private GameObject cables;
	private GameObject Pickup_cavi;
	private playerInventory playerInventory;

	// Use this for initialization
	void Start () {
		Pickup_cavi = GameObject.FindGameObjectWithTag ("Pickup_cavi");
		player = GameObject.FindGameObjectWithTag ("Player");
		cables = GameObject.FindGameObjectWithTag ("Cables");
		playerInventory = player.GetComponent <playerInventory>();
		Pickup_cavi.SetActive (false);
		
	}

	void OnTriggerEnter (Collider other){
		Pickup_cavi.SetActive (true);
	}
	
	void OnTriggerStay (Collider other){
		
		if (other.gameObject == player){
			if(Input.GetKeyDown(KeyCode.R)){
				Pickup_cavi.SetActive (false);
				playerInventory.hasCables = true;
				Destroy(cables.gameObject);
			}
		}
		
	}

	void OnTriggerExit (Collider other){
		
		if (other.gameObject == player){
			Pickup_cavi.SetActive (false);
		}
	}
	
	
}
