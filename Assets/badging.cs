using UnityEngine;
using System.Collections;

public class badging : MonoBehaviour {

	private GameObject player;
	private GameObject badge_door;
	private playerInventory playerInventory;
	private GameObject text_badger;
	private GameObject text_no_badge;
	private GameObject red_screen;
	private GameObject green_screen;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		badge_door = GameObject.FindGameObjectWithTag ("badge_door");
		playerInventory = player.GetComponent <playerInventory>();
		text_badger = GameObject.FindGameObjectWithTag ("text_badger");
		text_badger.SetActive (false);
		text_no_badge = GameObject.FindGameObjectWithTag ("text_no_badge");
		text_no_badge.SetActive (false);
		red_screen = GameObject.FindGameObjectWithTag ("red_screen");
		green_screen = GameObject.FindGameObjectWithTag ("green_screen");
		green_screen.SetActive (false);
		badge_door.collider.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			text_badger.SetActive (true);
		}
		
		
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			text_badger.SetActive (false);
			text_no_badge.SetActive (false);
		}
	}
	
	void OnTriggerStay (Collider other){
		if (other.gameObject == player) {
			if (Input.GetKeyDown (KeyCode.R)) {
				if (playerInventory.hasBadge == false){
					text_badger.SetActive (false);
					text_no_badge.SetActive (true);

				}
				else {
					red_screen.SetActive (false);
					green_screen.SetActive (true);
					badge_door.animation.Play("open_doors");
					StartCoroutine(Wait_for_closing ());
			}
		}


	}

	}

	IEnumerator Wait_for_closing () {

		yield return new WaitForSeconds (4);
		
		
		badge_door.animation.Play("close_doors");
		red_screen.SetActive (true);
		green_screen.SetActive (false);
		badge_door.collider.enabled = true;
		
	}







}
