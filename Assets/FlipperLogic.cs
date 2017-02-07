using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperLogic : MonoBehaviour {
	public HingeJoint2D hinge;
	public JointMotor2D motor;
	public AudioSource soundEffect;

	void Start () 
	{
		hinge = GetComponent<HingeJoint2D> ();
		motor = hinge.motor;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			soundEffect = gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			motor.motorSpeed = 750;
		} 
		else 
		{
			motor.motorSpeed = -500;
		}
		hinge.motor = motor;
	}
}
