using UnityEngine;
using System.Collections;

public class GUI_tastiera : MonoBehaviour {
	private GameObject text_tastiera;
	private GameObject player;
	private GameObject text_valve;
	private GameObject text_wrong_valve;
	//private Raycast script_raycast;

	// Use this for initialization
	void Start () {
		text_tastiera = GameObject.FindGameObjectWithTag ("GUI_codice");
		text_tastiera.SetActive (false);
		player = GameObject.FindGameObjectWithTag ("Player");
		text_valve = GameObject.FindGameObjectWithTag ("text_pick_up_valve");
		text_wrong_valve = GameObject.FindGameObjectWithTag ("text_pick_up_wrong_valve");
		//script_raycast = player.GetComponent<Raycast> ();
		//text_valve.SetActive (false);
		//text_wrong_valve.SetActive (false);
		//script_raycast.enabled = false;
		player.transform.FindChild("OVRCameraController").GetComponent<Raycast> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
				if (other.gameObject == player) {
			player.transform.FindChild("OVRCameraController").GetComponent<Raycast> ().enabled = true;
						print ("OK");
						text_tastiera.SetActive (true);
						StartCoroutine (Wait_for_text ());
				}
		}
	void OnTriggerExit(Collider other)
		{
		player.transform.FindChild("OVRCameraController").GetComponent<Raycast> ().enabled = false;
		}


	


	IEnumerator Wait_for_text () {
		
		yield return new WaitForSeconds (3);
		
		
		text_tastiera.SetActive (false);
		
		
	}


}
