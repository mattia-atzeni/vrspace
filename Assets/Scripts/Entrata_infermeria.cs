using UnityEngine;
using System.Collections;

public class Entrata_infermeria : MonoBehaviour {

	private GameObject player;
	private playerInventory PlayerInventory;
	public GameObject door;
	public GameObject testo_pre_infermeria;
	public GameObject collider;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		PlayerInventory = player.GetComponent<playerInventory>();
		testo_pre_infermeria.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player) {
			if(PlayerInventory.wounded==false)
			{
				door.collider.enabled=false;
				testo_pre_infermeria.SetActive(true);
			}
			else
			{
				door.collider.enabled=true;
				testo_pre_infermeria.SetActive(false);
				Destroy(collider);
			}
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject == player) {
			testo_pre_infermeria.SetActive(false);
		}
	}
}
