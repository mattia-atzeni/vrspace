using UnityEngine;
using System.Collections;

public class PickUpFireExtinguish : MonoBehaviour {
	private GameObject player;
	private playerInventory PlayerInventory;
	private GameObject pick_up_text;

	// Use this for initialization
	void Start () {
		pick_up_text = GameObject.FindGameObjectWithTag ("pick_up_text");
		player = GameObject.FindGameObjectWithTag ("Player");
		PlayerInventory = player.GetComponent<playerInventory>();
		pick_up_text.SetActive (false); // premi 'R' per raccogliere l'estintore

	
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		pick_up_text.SetActive (true); // premi 'R' per raccogliere l'estintore
	}

	void OnTriggerExit () {
		pick_up_text.SetActive (false); // premi 'R' per raccogliere l'estintore
	}

	void OnTriggerStay () {
		if (Input.GetKey (KeyCode.R)) {
			PlayerInventory.HasFireExtinguish = true;
			Object.Destroy (this.gameObject);
			pick_up_text.SetActive (false); // premi 'R' per raccogliere l'estintore
		}
	}
}
