using UnityEngine;
using System.Collections;

public class activate_cables : MonoBehaviour {

	public string levelToLoad;

	private GameObject Testo_inserimento_cavi;
	private GameObject Servirebbero_cavi;

	private GameObject player;
	private GameObject cableSet;
	private GameObject generator;
	private GameObject redLights;

	private generatorStatus generatorStatus;
	private playerInventory playerInventory;

	public bool CablesAreSet;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		cableSet = GameObject.FindGameObjectWithTag ("CableSet");
		Testo_inserimento_cavi = GameObject.FindGameObjectWithTag ("Testo_inserimento_cavi");
		Servirebbero_cavi = GameObject.FindGameObjectWithTag ("Servirebbero_cavi");
		generator = GameObject.FindGameObjectWithTag ("Generator");
		redLights = GameObject.FindGameObjectWithTag ("RedLights");

		playerInventory = player.GetComponent <playerInventory>();
		generatorStatus = generator.GetComponent <generatorStatus>();

		Testo_inserimento_cavi.SetActive (false);
		Servirebbero_cavi.SetActive(false);
		cableSet.SetActive(false);
		redLights.SetActive(false);
	
	}
	
	void OnTriggerEnter (Collider other){

		if (other.gameObject == player){
				if (playerInventory.hasCables == true){
					Testo_inserimento_cavi.SetActive (true);
				}
			else Servirebbero_cavi.SetActive(true);

		}
		
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject == player) {
			if (playerInventory.hasCables == true){
						if (Input.GetKeyDown (KeyCode.R)) {
								cableSet.SetActive (true);
								CablesAreSet = true;
								playerInventory.hasCables = false;
								Testo_inserimento_cavi.SetActive (false);
								print ("SONO QUI!");
								if (generatorStatus.IsOn == true) {
										redLights.SetActive (true);
										Application.LoadLevel (levelToLoad);
								}
						}	
					}
			}
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject == player) {
						Testo_inserimento_cavi.SetActive (false);
						Servirebbero_cavi.SetActive(false);
				}
	}
}
