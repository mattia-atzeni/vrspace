using UnityEngine;
using System.Collections;

public class insert_valve : MonoBehaviour {

	private GameObject player;
	private playerInventory playerInventory;
	public GameObject collider;
	public GameObject testo_collider;
	public GameObject testo_valvola_sbagliata;
	public GameObject testo_non_hai_valvola;
	public GameObject testo_ferita;
	public GameObject valvola;
	public GameObject smoke;
	private GameObject time;
	private TimerController timerController;
	private Color color;
	public GameObject Missione2;
	public GameObject Missione2_ok;
	public GameObject Missione3_pre;
	public GameObject Missione3;
	public GameObject Missione4_pre;
	public GameObject Missione4;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = player.GetComponent <playerInventory>();
		testo_collider.SetActive (false);
		testo_valvola_sbagliata.SetActive (false);
		testo_non_hai_valvola.SetActive (false);
		testo_ferita.SetActive (false);
		valvola.SetActive (false);
		Missione2_ok.SetActive (false);
		Missione3.SetActive (false);
		Missione4.SetActive (false);
		time = GameObject.FindGameObjectWithTag ("Time");
		timerController = time.GetComponent<TimerController> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			testo_collider.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			testo_collider.SetActive (false);
			testo_valvola_sbagliata.SetActive (false);
			testo_non_hai_valvola.SetActive (false);
			testo_ferita.SetActive (false);

			if(playerInventory.wounded==true) 
			{
				testo_ferita.SetActive (false);
				Destroy (collider);
			}
		}
	}

	void OnTriggerStay (Collider other){
		if (other.gameObject == player) {
			if (Input.GetKeyDown (KeyCode.R)) {
				testo_collider.SetActive (false);
				if (playerInventory.HasValve == true){
					valvola.SetActive (true);
					smoke.SetActive (false);
					timerController.startTime = (timerController.Timeleft);
					time.GetComponent<TimerController> ().enabled=false;
					time.guiText.text = "OXYGEN OK";
					time.guiText.color = Color.green;
					testo_ferita.SetActive (true);
					playerInventory.wounded=true;
					Missione2.SetActive(false);
					Missione2_ok.SetActive(true);
					Missione3_pre.SetActive(false);
					Missione3.SetActive(true);
					Missione4_pre.SetActive(false);
					Missione4.SetActive(true);
				}
				else if (playerInventory.HasWrongValve == true){
					testo_valvola_sbagliata.SetActive (true);
				}
				else testo_non_hai_valvola.SetActive (true);
			}
			
			
		}
		
	}

}
