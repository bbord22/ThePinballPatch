using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringLogic : MonoBehaviour {

	public float strength2;
	public float strength3;
	public float strength4;
	public float strength5;
	public float startTime;
	public float upTime;
	public float force;
	public ForceMode2D thrust;
	public Vector2 dir;
	public Rigidbody2D rb;
	public AudioSource soundEffect;

	void Start () 
	{
		soundEffect = GameObject.FindGameObjectWithTag ("LaunchSpring").GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody2D> ();
		thrust = ForceMode2D.Impulse;
		dir = Vector2.up;
		strength2 = .4f;
		strength3 = .8f;
		strength4 = 1.2f;
		strength5 = 1.4f;
		force = 0;
	}

	void Update () 
	{
		if (gameObject.GetComponent<CircleCollider2D> ().IsTouching (GameObject.FindWithTag ("LaunchSpring").GetComponent<BoxCollider2D> ())) 
		{

			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				startTime = Time.time;
			}

			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				upTime = Time.time - startTime;

				if (upTime < strength2) 
				{
					force = 11;
					rb.AddForce (dir*force, thrust);
					soundEffect.Play ();
				} 
				else if (strength2 < upTime && upTime < strength3) 
				{
					force = 15;
					rb.AddForce (dir*force, thrust);
					soundEffect.Play ();
				}
				else if (strength3 < upTime && upTime < strength4) 
				{
					force = 19;
					rb.AddForce (dir*force, thrust);
					soundEffect.Play ();
				}
				else if (strength4 < upTime && upTime < strength5) 
				{
					force = 24;
					rb.AddForce (dir*force, thrust);
					soundEffect.Play ();
				}
				else 
				{
					force = 31;
					rb.AddForce (dir*force, thrust);
					soundEffect.Play ();
				} 
			}
		}
	}
}
