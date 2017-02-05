using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BouncerLogic : MonoBehaviour
{


	//bumper variables
	public Rigidbody2D rb;
	public ForceMode2D thrust;
	public float force;
	public Vector2 dir;
	public float x1, x2, y1, y2;

	public void start()
	{
		rb = GetComponent<Rigidbody2D> ();
		thrust = ForceMode2D.Impulse;
	}

	public void OnCollisionEnter2D(Collision2D collN)
	{
		if (collN.gameObject.tag == "CircularBumper") 
		{
			force = 10;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);
		}

		if (collN.gameObject.tag == "WallBumper") 
		{
			force = 10;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);
		}
	}

}