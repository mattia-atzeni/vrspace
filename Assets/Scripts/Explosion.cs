using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	private GameObject player;
	private GameObject sector;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		sector = GameObject.FindGameObjectWithTag ("sector");
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
	
			if (other.gameObject == player) 
			{
				sector.animation.Play("updownrotation");
				audio.Play ();
			}

	}
}
