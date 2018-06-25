using UnityEngine;
using System.Collections;

public class display_text : MonoBehaviour {
	public static string password_text = "";
	public static int max_cifre = 0;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = password_text;
	
	}
}
