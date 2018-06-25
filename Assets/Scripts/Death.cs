using UnityEngine;
using System.Collections;


public class Death : MonoBehaviour {
	public string levelToLoad;
	private GameObject player;
	//private GameObject Deathlight;
	private GameObject time;
	private TimerController timerController;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		//Deathlight = GameObject.FindGameObjectWithTag ("Death_light");
		time = GameObject.FindGameObjectWithTag ("Time");
		timerController = time.GetComponent<TimerController> ();

		//Deathlight.SetActive(false);
	}
	

	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
			RenderSettings.ambientLight = Color.red;
			//Deathlight.SetActive(true);
			timerController.startTime = (timerController.Timeleft);
        	Application.LoadLevel(levelToLoad);
			
			
			
		}
	
}
}
