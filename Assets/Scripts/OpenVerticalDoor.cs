using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OpenVerticalDoor : MonoBehaviour {
	private GameObject player;
	public AudioClip clip;

	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		audio.clip = clip;
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			animation.Play("OpenVerticalDoor");
			audio.Play();
			
		}

		
	}
	
	void OnTriggerExit (Collider other) {

		if (other.gameObject.tag == "Player") {
			animation.Play ("CloseVerticalDoor");
			audio.Play();
		}
		
		
	}
}
