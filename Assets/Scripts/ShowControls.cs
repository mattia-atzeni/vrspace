using UnityEngine;
using System.Collections;

public class ShowControls : MonoBehaviour {

	public GameObject controls;

	// Use this for initialization
	void Start () {
		controls.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
						controls.SetActive (true);
				}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
						controls.SetActive (false);
				}
	}
}
