using UnityEngine;
using System.Collections;

public class PickUpBadge : MonoBehaviour {

	private GameObject player;
	private playerInventory PlayerInventory;
	public GameObject pick_up_text;
	public GameObject Sector_C;
	
	// Use this for initialization
	void Start () {
		//pick_up_text = GameObject.FindGameObjectWithTag ("pick_up_badge_text");
		player = GameObject.FindGameObjectWithTag ("Player");
		PlayerInventory = player.GetComponent<playerInventory>();
		pick_up_text.SetActive (false); // premi 'R' per raccogliere il badge
		Sector_C.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		pick_up_text.SetActive (true); // premi 'R' per raccogliere il badge
	}
	
	void OnTriggerExit (Collider other) {
		pick_up_text.SetActive (false); // premi 'R' per raccogliere il badge
	}
	
	void OnTriggerStay (Collider other) {
				if (other.gameObject == player) {
						if (Input.GetKey (KeyCode.R)) {
								PlayerInventory.hasBadge = true;
								Object.Destroy (this.gameObject);
								pick_up_text.SetActive (false); // premi 'R' per raccogliere il badge
								Sector_C.SetActive (true);
						}
				}
		}
}
