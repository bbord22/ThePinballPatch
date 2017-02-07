using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftFlipperLogic : MonoBehaviour {
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
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			soundEffect = gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			motor.motorSpeed = -750;
		} 
		else 
		{
			motor.motorSpeed = 500;
		}
		hinge.motor = motor;
	}
}
