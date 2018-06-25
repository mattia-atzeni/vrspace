using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OpenDoor : MonoBehaviour {
	
	private GameObject player;
	public AudioClip clip;
	//private GameObject leftDoor;
	//private GameObject rightDoor;
	//private PlayerInventory playerInventory;
	
	
	void Awake () {
		
		player = GameObject.FindGameObjectWithTag ("Player");
		audio.clip = clip;
		//playerInventory = player.GetComponent<PlayerInventory> ();
		//rightDoor = GameObject.FindGameObjectWithTag ("right_door");
		//leftDoor = GameObject.FindGameObjectWithTag ("left_door");
		
		
	}
	
	
	void OnTriggerEnter (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Play("open_doors");
			audio.Play();
			
		}
		
		
		//}
		
		
	}
	
	void OnTriggerExit (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Play ("close_doors");
			audio.Play();
			
			
			//}
		}
		
		
	}
}

