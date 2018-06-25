var levelToLoad : String;
var soundhover : AudioClip;
var beep : AudioClip;
var QuitButton : boolean = false;
 
function OnMouseEnter(){
    audio.PlayOneShot(soundhover);
}
 
function Update(){
    audio.PlayOneShot(beep);
    //yield new WaitForSeconds(0.35);
    //if(QuitButton){
    if(Input.GetKeyDown(KeyCode.Q)){
        Application.Quit();
    }
    else if(Input.GetKeyDown(KeyCode.P)){
        Application.LoadLevel(levelToLoad);
    }
}
 
@script RequireComponent(AudioSource)