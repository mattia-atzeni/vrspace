using UnityEngine;
using System.Collections;

public class Troppo_alto : MonoBehaviour {

	private GameObject player;
	private GameObject text;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		text = GameObject.FindGameObjectWithTag ("Troppo_alto");
		text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player){
			text.SetActive (true);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player){
			text.SetActive (false);
		}
	}
}
