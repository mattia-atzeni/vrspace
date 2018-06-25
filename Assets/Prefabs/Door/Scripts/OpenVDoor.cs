using UnityEngine;
using System.Collections;

public class OpenVDoor : MonoBehaviour {
	
	private GameObject player;
	//private GameObject leftDoor;
	//private GameObject rightDoor;
	//private PlayerInventory playerInventory;
	
	
	void Awake () {
		
		player = GameObject.FindGameObjectWithTag ("Player");
		//playerInventory = player.GetComponent<PlayerInventory> ();
		//rightDoor = GameObject.FindGameObjectWithTag ("right_door");
		//leftDoor = GameObject.FindGameObjectWithTag ("left_door");
		
		
	}
	
	
	void OnTriggerEnter (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Play("open_up");
			
			
		}
		
		
		//}
		
		
	}
	
	void OnTriggerExit (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Play ("close_up");
			
			
			//}
		}
		
		
	}
}

