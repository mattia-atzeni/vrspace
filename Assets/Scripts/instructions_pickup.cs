using UnityEngine;
using System.Collections;

public class instructions_pickup : MonoBehaviour {

	private GameObject player;
	private GameObject instructions;
	private GameObject Pickup_istruzioni;
	private playerInventory playerInventory;
	
	// Use this for initialization
	void Start () {
		Pickup_istruzioni = GameObject.FindGameObjectWithTag ("Pickup_istruzioni");
		player = GameObject.FindGameObjectWithTag ("Player");
		instructions = GameObject.FindGameObjectWithTag ("Instructions");

		playerInventory = player.GetComponent <playerInventory>();
		Pickup_istruzioni.SetActive (false);
		
	}
	
	
	void OnTriggerEnter (Collider other){
				Pickup_istruzioni.SetActive (true);
		}

	void OnTriggerStay (Collider other){
		
		if (other.gameObject == player){
			if(Input.GetKeyDown(KeyCode.R)){
				Pickup_istruzioni.SetActive (false);
				playerInventory.hasInstructions = true;
				Destroy(instructions.gameObject);
			}
		}
		
	}
	void OnTriggerExit (Collider other){
		
		if (other.gameObject == player){
			Pickup_istruzioni.SetActive (false);
		}
}
}
