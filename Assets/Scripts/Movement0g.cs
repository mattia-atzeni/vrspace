using UnityEngine;
using System.Collections;

public class Movement0g : MonoBehaviour {
	public float speed;
	public float turnSpeed;
	public float stabilizationSpeed;
	private GameObject player;
	public Vector3 vel;
	public Vector3 ang_vel;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		speed=0.8f;
		turnSpeed = 0.15f;
		stabilizationSpeed=1.5f;
		vel = player.rigidbody.velocity;
		ang_vel = player.rigidbody.angularVelocity;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if (Input.GetButton("Fire1")) { //Spacebar by default will make it move forward
			player.rigidbody.AddRelativeForce (Vector3.forward*speed);
			//player.transform.localPosition=new Vector3(0,0,speed);
		}
		if (Input.GetButton("Fire2")) { 
			player.rigidbody.AddRelativeForce (Vector3.back*speed);
			//player.transform.localPosition=new Vector3(0,0,-speed);
		}
		if (Input.GetButton("Fire3")) { print ("QUA");
			player.rigidbody.velocity=new Vector3(vel.x/=stabilizationSpeed, vel.y/=stabilizationSpeed, vel.z/=stabilizationSpeed);
			player.rigidbody.angularVelocity=new Vector3(ang_vel.x/=stabilizationSpeed, ang_vel.y/=stabilizationSpeed, ang_vel.z/=stabilizationSpeed);
			//ang_vel.x/=stabilizationSpeed;
			//vel.y/=stabilizationSpeed;ang_vel.y/=stabilizationSpeed;
			//vel.z/=stabilizationSpeed;ang_vel.z/=stabilizationSpeed;
			//rigidbody.velocity = Vector3.zero;
			//rigidbody.angularVelocity = Vector3.zero;
		}
		player.rigidbody.AddRelativeTorque ((Input.GetAxis("Vertical"))*turnSpeed*(-1),0,0);
		// W key or the up arrow to turn upwards, S or the down arrow to turn downwards.
		player.rigidbody.AddRelativeTorque (0,(Input.GetAxis("Horizontal"))*turnSpeed,0);
		// A or left arrow to turn left, D or right arrow to turn right. 
	}
}
