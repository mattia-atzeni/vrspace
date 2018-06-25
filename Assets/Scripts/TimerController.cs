using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour {
	
	public float startTime;
	public float restSeconds;
	public float roundedRestSeconds;
	public float duration;
	public string levelToLoad;
	public float Timeleft;
	string timetext;
	public float CountDownSeconds;
	
	// Use this for initialization
	
	void Start () 
	{
		startTime = Time.deltaTime;
		CountDownSeconds = 100 * duration;
	}
	
	void OnGUI()
	{
		
		Timeleft = Time.time - startTime;
		
		restSeconds = (CountDownSeconds - (Timeleft)) / duration;
		
		roundedRestSeconds = Mathf.CeilToInt(restSeconds);

		
		timetext = ( "OXYGEN: "+roundedRestSeconds.ToString()+ " %" );
		guiText.text = timetext;
		if(timetext=="OXYGEN: 0 %") Application.LoadLevel(levelToLoad);
	}
}