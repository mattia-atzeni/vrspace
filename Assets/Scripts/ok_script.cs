using UnityEngine;
using System.Collections;

public class ok_script : MonoBehaviour {
	private GameObject player;
	private GameObject valve;
	private GameObject wrong_valve;
	private GameObject needle;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		valve = GameObject.FindGameObjectWithTag ("valve");
		wrong_valve = GameObject.FindGameObjectWithTag ("wrong_valve");
		needle = GameObject.FindGameObjectWithTag ("needle");
		valve.SetActive (false);
		wrong_valve.SetActive (false);

	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0)){
			needle.animation.Play("3dprinteranimation");
			StartCoroutine(Printing());
		}

	}

	IEnumerator Printing () {
		
		yield return new WaitForSeconds (3);
		if (display_text.password_text == "1234") {
			valve.SetActive (true);
			player.transform.Translate (0.00001f,0,0);
		}
		else {
			wrong_valve.SetActive (true);
			player.transform.Translate (0.00001f,0,0);
		}
	}






}
