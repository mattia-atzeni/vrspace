var AudioFileSlow : AudioClip;
var AudioFileFast : AudioClip;

function Update() {

	if (Input.GetKeyUp (KeyCode.W))
	{
		if (Input.GetKeyUp (KeyCode.LeftShift))
		{
		    audio.clip = AudioFileFast;
		    audio.Stop();
		}
		else
		{
			audio.clip = AudioFileSlow;
		    audio.Stop();
	    }
	}
}