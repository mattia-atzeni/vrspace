using UnityEngine;
using System.Collections;

public class PlayMedPodAnimation : MonoBehaviour {

	public AudioClip clip;
	private GameObject player;

	void Start () {
				player = GameObject.FindGameObjectWithTag ("Player");
		}

	void OnTriggerEnter ( Collider other ) {
				if (other.gameObject == player) {
					audio.clip = clip;
					audio.Play ();
					print ("OK");
					animation.PlayQueued ("medPod_open_new", QueueMode.CompleteOthers);
				}


	}

	void OnTriggerExit ( Collider other ) {
		if (other.gameObject == player) {
					audio.clip = clip;
					audio.Play ();
					animation.PlayQueued ("medPod_close_new", QueueMode.CompleteOthers);
				}
	}
}
