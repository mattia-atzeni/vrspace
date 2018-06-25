using UnityEngine;
using System.Collections;

public class FlameController : MonoBehaviour {
	private GameObject gui_flame;
	private GameObject foam;
	private GameObject player;
	private GameObject flameOFF;
	private GameObject flame_block;
	private playerInventory PlayerInventory;

	// Use this for initialization
	void Start () {
		gui_flame = GameObject.FindGameObjectWithTag ("gui_flame");
		gui_flame.SetActive (false);
		foam = GameObject.FindGameObjectWithTag ("foam");
		foam.SetActive (false);
		flameOFF = GameObject.FindGameObjectWithTag ("flameOFF");
		flame_block = GameObject.FindGameObjectWithTag ("flame_block");
		player = GameObject.FindGameObjectWithTag ("Player");
		PlayerInventory = player.GetComponent<playerInventory>();
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {

		if (PlayerInventory.HasFireExtinguish) {

			StartCoroutine(Extinguing ());

		
		} else {
			gui_flame.SetActive (true);
		
		}

	
	}

	void OnTriggerExit () {
		gui_flame.SetActive (false);

		
		
	}

	IEnumerator Extinguing () {
		foam.SetActive (true);

		yield return new WaitForSeconds (4);


		Destroy (flameOFF.gameObject);
		Destroy (flame_block.gameObject);

		yield return new WaitForSeconds (1);

		foam.SetActive (false);
		
		GameObject.Destroy (this.gameObject);

	
	}
}
