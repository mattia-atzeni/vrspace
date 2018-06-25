#pragma strict

private var startTime : float;
var textTime : String;
var duration : float;
var levelToLoad : String;
static var color: Color;


function Start () {
	startTime = Time.time;
	duration = 1200f;
}

function OnGUI () {
	var guiTime = duration-(Time.time - startTime);
	
	var minutes : int = guiTime / 60;
	var seconds : int = guiTime % 60;
	var fraction : int = (guiTime * 100) % 100;
	
	textTime = String.Format ("TIME LEFT : {0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
	if(guiTime<=11f) this.guiText.color=Color.red;
	GetComponent(GUIText).text = textTime;
	if(guiTime<=0f) 
	{
		Application.LoadLevel(levelToLoad);
	}
}