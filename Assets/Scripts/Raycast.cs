using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Raycast : MonoBehaviour
{
    private RaycastHit hit;
    private GameObject target;
    private GameObject player;
    private GameObject valve;
    private GameObject wrong_valve;
	private GameObject text_valve;
	private GameObject text_wrong_valve;
    private GameObject needle;
	private GameObject zero, uno, due, tre, quattro, cinque, sei, sette, otto, nove, canc, ok;
	private GameObject Comandi;
	private int flag;

	public AudioClip clip;

    // Use this for initialization
    void Start ()
    {
        target = GameObject.FindGameObjectWithTag ("Target");
        player = GameObject.FindGameObjectWithTag ("Player");
        valve = GameObject.FindGameObjectWithTag ("valve");
        wrong_valve = GameObject.FindGameObjectWithTag ("wrong_valve");
        needle = GameObject.FindGameObjectWithTag ("needle");
		zero = GameObject.FindGameObjectWithTag ("Zero");
		uno = GameObject.FindGameObjectWithTag ("Uno");
		due = GameObject.FindGameObjectWithTag ("Due");
		tre = GameObject.FindGameObjectWithTag ("Tre");
		quattro = GameObject.FindGameObjectWithTag ("Quattro");
		cinque = GameObject.FindGameObjectWithTag ("Cinque");
		sei = GameObject.FindGameObjectWithTag ("Sei");
		sette = GameObject.FindGameObjectWithTag ("Sette");
		otto = GameObject.FindGameObjectWithTag ("Otto");
		nove = GameObject.FindGameObjectWithTag ("Nove");
		canc = GameObject.FindGameObjectWithTag ("Canc");
		ok = GameObject.FindGameObjectWithTag ("Ok");
		Comandi = GameObject.FindGameObjectWithTag ("Controls");
		//text_valve = GameObject.FindGameObjectWithTag ("text_pick_up_valve");
		//text_wrong_valve = GameObject.FindGameObjectWithTag ("text_pick_up_wrong_valve");
		//text_wrong_valve.SetActive (false);
		//text_valve.SetActive (false);
        valve.SetActive (false);
        wrong_valve.SetActive (false);
		flag = -1;
		audio.clip = clip;
		Comandi.SetActive (false);
    }

    // Update is called once per frame
    void Update ()
    {
		if (Input.GetKeyDown (KeyCode.H)) {
			Comandi.SetActive (true);
				}
		if (Input.GetKeyUp (KeyCode.H)) {
			Comandi.SetActive (false);
		}

		Debug.DrawLine(target.transform.position, transform.position, Color.green);
		if (Physics.Linecast (target.transform.position, transform.position, out hit))
        {
            //if (Input.GetKeyDown (KeyCode.R)) 
			//{ 
            if (hit.collider.gameObject.CompareTag("Canc"))
			{	
				print ("CANC");flag=10; hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);               
            }
            else if (hit.collider.gameObject.CompareTag("Ok"))
			{   
				print ("TASTO OK");flag=11; hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);               
            }
             //if (display_text.max_cifre < 4)
            //{
                else if (hit.transform.gameObject.CompareTag("Zero"))
                {
				print ("ZERO");flag=0;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Uno"))
                {
				print ("UNO");flag=1;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Due"))
                {
				print ("DUE");flag=2;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Tre"))
                {
				print ("TRE");flag=3;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Quattro"))
                {
				print ("QUATTRO");flag=4;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Cinque"))
                {
				print ("CINQUE");flag=5;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
					//if (Input.GetKeyDown (KeyCode.R))
                    //{
                        //display_text.password_text = display_text.password_text + "5";
                        //display_text.max_cifre = display_text.max_cifre + 1;
                    //}
                }
			else if (hit.transform.gameObject.CompareTag("Sei"))
                {
				print ("SEI");flag=6;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Sette"))
                {
				print ("SETTE");flag=7;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Otto"))
                {
				print ("OTTO");flag=8;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else if (hit.transform.gameObject.CompareTag("Nove"))
                {
				print ("NOVE");flag=9;hit.transform.gameObject.renderer.material.SetColor("_Color", Color.green);
                }
			else
			{
				zero.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				uno.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				due.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				tre.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				quattro.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				cinque.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				sei.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				sette.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				otto.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				nove.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				canc.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
				ok.transform.gameObject.renderer.material.SetColor("_Color", Color.white);
			}


                //}
            //}
        }
		if(flag!=-1)
		{
		if(flag==10)
		{
			if (Input.GetMouseButtonDown(0))
			{
				audio.Play();
			display_text.password_text = "";
			display_text.max_cifre = 0;
			}
		}
		else if(flag==11)
		{
			if (Input.GetMouseButtonDown(0))
			{
				audio.Play();
			needle.animation.Play("3dprinteranimation");
			StartCoroutine(Printing());
			}
		}

	else if (display_text.max_cifre < 4)
		if (Input.GetMouseButtonDown(0))
		{
			audio.Play();
			display_text.password_text = display_text.password_text + flag;
			display_text.max_cifre = display_text.max_cifre + 1;
		}
    }
	}

    IEnumerator Printing ()
    {
		print ("PRINTING!!!!!!!!!");
        yield return new WaitForSeconds (3);
        if (display_text.password_text == "8416")
        {
            valve.SetActive (true);
            player.transform.Translate (0.00001f,0,0);
        }
        else
        {
            wrong_valve.SetActive (true);
            player.transform.Translate (0.00001f,0,0);
        }
    }
}

