using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperLogic : MonoBehaviour 
{
	public HingeJoint2D hinge;
	public float reference;

	void Start () 
	{
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		reference = 213.02f;
		hinge.referenceAngle = 213.02;
	}
	

	void Update () {
		
	}
}
