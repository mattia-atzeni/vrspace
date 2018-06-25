using UnityEngine;
using System.Collections;

public class MedKitPickUp : MonoBehaviour {

	private GameObject player;
	private playerInventory playerInventory;
	public GameObject testo_collider;
	public GameObject medkit;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = player.GetComponent <playerInventory>();
		testo_collider.SetActive (false);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			testo_collider.SetActive (true);
		}
	}

	void OnTriggerStay (Collider other){
		if (other.gameObject == player) {
			if (Input.GetKeyDown (KeyCode.R)) {
				testo_collider.SetActive (false);
				playerInventory.wounded=false;
				Destroy(medkit);
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			testo_collider.SetActive (false);
		}
	}
}
