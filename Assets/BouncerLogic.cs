using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BouncerLogic : MonoBehaviour
{

	public Rigidbody2D rb;
	public Collision2D collN;
	public ForceMode2D thrust;
	public float force;
	Vector2 dir;


	public void start()
	{
		rb = GetComponent<Rigidbody2D> ();
		thrust = ForceMode2D.Impulse;
		collN = GetComponent<Collision2D> ();
	}

	public void OnCollisionEnter2D(Collision2D collN)
	{
		if (collN.gameObject.tag == "Circular Bumper") 
		{
			force = 5;
			float x1 = collN.contacts [0].point.x;
			float y1 = collN.contacts[0].point.y;
			float x2 = transform.position.x;
			float y2 = transform.position.y;
			dir.x = x1 - x2;
			dir.y = y1 - y2;
			dir = -dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);
		}

		/*else if (collN.gameObject.tag == "LaunchSpring") 
		{
			if()
			{
				
			}
		}*/
	}

}
