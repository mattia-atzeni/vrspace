var AudioFileSlow : AudioClip;
var AudioFileFast : AudioClip;
public var flag : int;

function Start() {
	flag=0;
}

function Update() {

	if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D)) 
	{
	
		audio.clip = AudioFileSlow;
		audio.Play();
	}
	if (Input.GetKeyDown (KeyCode.LeftShift) && flag==0)
	{
		print("DEBUG");
		flag=1;
	    audio.clip = AudioFileFast;
	    audio.Play();
	}
	
	if (Input.GetKeyUp (KeyCode.LeftShift))
	{
		audio.Stop();
		flag=0;
		audio.clip = AudioFileSlow;
		//audio.Play();
	}
	
	if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.D))
	{
		audio.Stop();
	}

}