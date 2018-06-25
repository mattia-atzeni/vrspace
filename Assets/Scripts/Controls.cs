using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	private GameObject Comandi;
	private GameObject player;
	// Use this for initialization
	void Start () {
		Comandi = GameObject.FindGameObjectWithTag ("Controls");
		player = GameObject.FindGameObjectWithTag ("Player");
		//Comandi.SetActive (false);
	}

	void OnTriggerEnter (Collider other){
		
		if (other.gameObject == player){
				Comandi.SetActive (true);		
		}
		
	}

	void OnTriggerExit (Collider other){
		
		if (other.gameObject == player){
			Comandi.SetActive (false);		
		}
		
	}
}
