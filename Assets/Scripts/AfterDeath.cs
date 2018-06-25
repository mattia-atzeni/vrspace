using UnityEngine;
using System.Collections;

public class AfterDeath : MonoBehaviour {
	public string levelToLoad;
	public void OnGUI() { if(Input.GetKeyDown(KeyCode.M))
		/*if (Event.current.type == EventType.KeyDown) {
			KeyPressedEventHandler();
		}
	}
	
	private void KeyPressedEventHandler() {*/
		Application.LoadLevel(levelToLoad);
	}
}
