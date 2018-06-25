using UnityEngine;
using System.Collections;

public class disableCollider : MonoBehaviour {
	public Collider wrong_valve_collider;

	// Use this for initialization
	void Start () {
		//collider = SphereCollider;
		wrong_valve_collider = this.GetComponent<SphereCollider>();


		wrong_valve_collider.enabled = false;
		//GetComponents (SphereCollider).SetValue (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
