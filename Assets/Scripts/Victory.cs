using UnityEngine;
using System.Collections;


public class Victory : MonoBehaviour {
	public string levelToLoad;
	private GameObject player;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel(levelToLoad);
		}
		
	}
}
