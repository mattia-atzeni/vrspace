using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour {

	public int flag = 1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftControl) && flag == 1) {
						transform.localScale += new Vector3 (0, -0.5f, 0);
						flag=0;
				}
		else if (Input.GetKeyDown (KeyCode.LeftControl) && flag==0) {
						transform.localScale += new Vector3 (0, 0.5f, 0);
						transform.position+= new Vector3(0, 2.0f, 0);
						flag=1;
				}
	}
}
