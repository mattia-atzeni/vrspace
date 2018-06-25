using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Explosion_text : MonoBehaviour {
	
	private GameObject player;
	public GUIText testo;
	public AudioClip clip;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		testo.enabled =(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject == player) 
		{
			audio.Play();
		}
		
	}
	void OnTriggerStay (Collider other) {
		testo.enabled =(true);
	}
	void OnTriggerExit (Collider other) {
		testo.enabled =(false);
		Destroy (this);
	}
}
