using UnityEngine;
using System.Collections;

public class disable_valve_collider : MonoBehaviour {


		private Collider valve_collider;
		
		// Use this for initialization
		void Start () {
			//collider = SphereCollider;
			valve_collider = this.GetComponent<SphereCollider>();
			
			
			valve_collider.enabled = false;
			//GetComponents (SphereCollider).SetValue (false);
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

}
