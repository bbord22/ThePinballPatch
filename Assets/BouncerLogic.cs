using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BouncerLogic : MonoBehaviour
{

	public Rigidbody2D rb;
	public Collision2D collN;
	public ForceMode2D thrust;
	public Vector2 force;


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
			force.x = 0;
			force.y = 5;
			rb.AddRelativeForce (force, thrust);
		}

		/*else if (collN.gameObject.tag == "LaunchSpring") 
		{
			
		}*/
	}

}
