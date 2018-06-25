using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OpenBrokenDoor : MonoBehaviour {

	private GameObject player;
	public AudioClip clip;
	//private GameObject player;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		audio.clip = clip;
		
	//	player = GameObject.FindGameObjectWithTag ("Player");
		//playerInventory = player.GetComponent<PlayerInventory> ();
		//rightDoor = GameObject.FindGameObjectWithTag ("right_door");
		//leftDoor = GameObject.FindGameObjectWithTag ("left_door");
		
		
	}
	
	void OnTriggerEnter (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Play("open_broken_doors");
			audio.Play();
			
		}
		
		
		//}
		
		
	}
	
	void OnTriggerExit (Collider other) {
		//if (playerInventory.hasKey) {
		if (other.gameObject.tag == "Player") {
			animation.Stop ("open_broken_doors");
			audio.Stop();
			
			//}
		}
		
		
	}
}
