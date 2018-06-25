using UnityEngine;
using System.Collections;

public class ActivateJetpack2 : MonoBehaviour {

	public GameObject player;
	public GameObject jetpack;
	//public GameObject sfera;
	public Transform sfera_transform;
	public AudioClip jetpack_sound;

	// Use this for initialization
	void Start () {
		//player = GameObject.FindGameObjectWithTag ("player");
		player.GetComponent<Movement0g>().enabled = false;
		//sfera = player.transform.FindChild ("Sphere");

		//sfera.SetActive (false);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player"){
			//sfera.SetActive (true);
			//sfera.transform.position=player.transform.position;
			//sfera.transform.rotation=player.transform.rotation;
			//player.AddComponent("Rigidbody");
			player.GetComponent<Rigidbody>().isKinematic = false;

			player.GetComponent<Rigidbody>().useGravity = false;
			player.GetComponent<OVRMainMenu>().enabled = false;
			player.GetComponent<OVRPlayerController>().enabled = false;
			player.GetComponent<OVRGamepadController>().enabled = false;
			player.GetComponent<CharacterController>().enabled = false;
			//player.GetComponent<AudioSource>().enabled = false;
			player.GetComponent<FootStepsAll>().walk=jetpack_sound;
			player.GetComponent<FootStepsAll>().run=jetpack_sound;
			player.GetComponent<FootStepsAll>().jetpackOn=true;
			player.GetComponent<Movement0g>().enabled = true;
			player.AddComponent<CapsuleCollider>();
			player.GetComponent<CapsuleCollider>().isTrigger=true;
			player.GetComponent<CapsuleCollider>().radius=1.2f;
			//player.GetComponent<OVRCameraController>().FollowOrientation = player.transform.FindChild("ForwardDirection").transform;
			Destroy (jetpack);
		}
	}
}
