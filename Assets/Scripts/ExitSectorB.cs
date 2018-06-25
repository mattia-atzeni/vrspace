using UnityEngine;
using System.Collections;

public class ExitSectorB : MonoBehaviour {

	private GameObject player;
	private playerInventory playerInventory;
	public GameObject non_puoi_passare;
	public GameObject door;
	private GameObject generator;
	private generatorStatus generatorStatus;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = player.GetComponent <playerInventory>();
		non_puoi_passare.SetActive(false);
		generator = GameObject.FindGameObjectWithTag ("Generator");
		generatorStatus = generator.GetComponent <generatorStatus>();
	}

	void OnTriggerEnter (Collider other){
		
		if (other.gameObject == player){
			
			if(playerInventory.wounded == true) 
			{
				door.collider.enabled=false;
				non_puoi_passare.SetActive(true);
			}
			else if(generatorStatus.IsOn==true)
			{
				door.collider.enabled=true;
				non_puoi_passare.SetActive(false);
			}

		}
	}

	void OnTriggerExit (Collider other){
			non_puoi_passare.SetActive(false);
		}
	
}
