using UnityEngine;
using UnityEngine;
using System.Collections;

public class ArrivoCupola : MonoBehaviour {
	
	public GameObject text;
	private GameObject player;
	private Crouch script;
	
	// Use this for initialization
	void Start () {
		text.SetActive (false);
		player = GameObject.FindGameObjectWithTag ("Player");
		script = player.GetComponent <Crouch>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
						text.SetActive (true);
						script.flag = 1;
						player.transform.localScale += new Vector3 (0, 0.5f, 0);
						player.transform.position += new Vector3 (0, 2.0f, 0);
				}
	}
	
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
						text.SetActive (false);
				}
	}
}
