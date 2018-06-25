using UnityEngine;
using System.Collections;

public class activate_generator : MonoBehaviour {

	private GameObject player;
	private GameObject Testo_generatore;
	private GameObject Testo_generatore_off;
	private GameObject Testo_istruzioni;
	private GameObject Testo_cavi;
	private GameObject Generatore_spento;
	private GameObject cableBox;
	private GameObject generator;
	private GameObject fullLights;
	private GameObject DoorB;
	private GameObject DoorA;
	private GameObject SectorBRED;
	private GameObject SectorBGREEN;
	private GameObject SectorARED;
	private GameObject SectorAGREEN;
	private GameObject Missione1;
	private GameObject Missione1OK;
	private GameObject Missione2pre;
	private GameObject Missione2;
	private GameObject Missione2OK;
	private GameObject time;
	public GameObject smoke;
	public GameObject luci_rosse;


	public AudioSource clip;
	
	private generatorStatus generatorStatus;
	private playerInventory playerInventory;
	private activate_cables activate_cables;
	private TimerController timerController;


	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		cableBox = GameObject.FindGameObjectWithTag ("CableBox");
		generator = GameObject.FindGameObjectWithTag ("Generator");
		fullLights = GameObject.FindGameObjectWithTag ("FullLights");
		Testo_generatore = GameObject.FindGameObjectWithTag ("Testo_generatore");
		Testo_generatore_off = GameObject.FindGameObjectWithTag ("Testo_generatore_off");
		Testo_istruzioni = GameObject.FindGameObjectWithTag ("Testo_istruzioni");
		Testo_cavi = GameObject.FindGameObjectWithTag ("Testo_cavi");
		Generatore_spento = GameObject.FindGameObjectWithTag ("Generatore_spento");
		DoorB = GameObject.FindGameObjectWithTag ("Door_sector_B");
		DoorA = GameObject.FindGameObjectWithTag ("Door_sector_A");
		SectorBRED = GameObject.FindGameObjectWithTag ("SectorBRED");
		SectorBGREEN = GameObject.FindGameObjectWithTag ("SectorBGREEN");
		SectorARED = GameObject.FindGameObjectWithTag ("SectorARED");
		SectorAGREEN = GameObject.FindGameObjectWithTag ("SectorAGREEN");
		Missione1 = GameObject.FindGameObjectWithTag ("Missione1");
		Missione1OK = GameObject.FindGameObjectWithTag ("Missione1OK");
		Missione2pre = GameObject.FindGameObjectWithTag ("Missione2pre");
		Missione2 = GameObject.FindGameObjectWithTag ("Missione2");
		Missione2OK = GameObject.FindGameObjectWithTag ("Missione2OK");
		time = GameObject.FindGameObjectWithTag ("Time");
		timerController = time.GetComponent<TimerController> ();

		generatorStatus = generator.GetComponent <generatorStatus>();
		playerInventory = player.GetComponent <playerInventory>();
		activate_cables = cableBox.GetComponent <activate_cables>();
		Testo_generatore.SetActive (false);
		Testo_generatore_off.SetActive (false);
		Testo_istruzioni.SetActive (false);
		Testo_cavi.SetActive (false);
		Generatore_spento.SetActive (false);
		SectorBGREEN.SetActive (false);
		SectorAGREEN.SetActive (false);
		Missione1OK.SetActive (false);
		Missione2.SetActive (false);
		Missione2OK.SetActive (false);
		fullLights.SetActive(false);

		//audio.clip = clip;


		//cableSet.SetActive(false);

	}
	
	void OnTriggerEnter (Collider other){
		
		if (other.gameObject == player){

			if(generatorStatus.IsOn == false) 
				Testo_generatore.SetActive (true); 
			else Testo_generatore_off.SetActive (true);
		}
		
	}
	void OnTriggerStay (Collider other){
		if (other.gameObject == player) {
				if(Input.GetKeyDown(KeyCode.R)){
					if(generatorStatus.IsOn == false) 
						Testo_generatore.SetActive (false);
					else Testo_generatore_off.SetActive (false);
					
					if (playerInventory.hasInstructions == false){
						Testo_istruzioni.SetActive (true);
					}

					if (playerInventory.hasInstructions == true){
						//Testo_istruzioni.SetActive (false);
						if(generatorStatus.IsOn == false)
						{	
							generatorStatus.IsOn = true;
							Generatore_spento.SetActive (false);
						}
						else 
						{
							generatorStatus.IsOn = false;
							Generatore_spento.SetActive (true);
							Testo_cavi.SetActive(false);
						}
						
						if (activate_cables.CablesAreSet == false){
							if(generatorStatus.IsOn == true)
								Testo_cavi.SetActive (true);
						}
						if (activate_cables.CablesAreSet == true){
							fullLights.SetActive(true);
							DoorB.collider.enabled=true;
							DoorA.collider.enabled=true;
							SectorBRED.SetActive(false);
							SectorBGREEN.SetActive(true);
							SectorARED.SetActive(false);
							SectorAGREEN.SetActive(true);
							Missione1.SetActive (false);
							Missione1OK.SetActive (true);
							Missione2pre.SetActive (false);
							Missione2.SetActive(true);
							
							timerController.startTime = (timerController.Timeleft);
							smoke.SetActive(false);
							luci_rosse.SetActive(false);
							clip.Play();
							Destroy(this.collider);
						}
					}
			}
		}
	}
	void OnTriggerExit (Collider other){
		
		if (other.gameObject == player){
			
			Testo_generatore.SetActive (false); 
			Testo_generatore_off.SetActive (false);
			Testo_istruzioni.SetActive (false);
			Testo_cavi.SetActive (false);
			Generatore_spento.SetActive (false);
		}
		
	}
}
