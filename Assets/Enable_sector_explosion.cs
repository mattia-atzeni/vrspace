using UnityEngine;
using System.Collections;

public class Enable_sector_explosion : MonoBehaviour {

	public GameObject sector;
	private GameObject player;

	// Use this for initialization
	void Start () {
		sector.SetActive (false);
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player) {
						sector.SetActive (true);
				}
	}
}
