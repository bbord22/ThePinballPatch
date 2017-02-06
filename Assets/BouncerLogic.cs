using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BouncerLogic : MonoBehaviour
{


	//bumper variables
	public Rigidbody2D rb;
	public ForceMode2D thrust;
	public SpriteRenderer rend;
	public Sprite largebumperalternate;
	public Sprite bottomleftbumperalternate;
	public Sprite bottomrightbumperalternate;
	public Sprite sidebumperalternate;
	public Vector2 dir;
	public float force;
	public float x1, x2, y1, y2;
	public int ballNumber = 1;

	public void start()
	{
		rb = GetComponent<Rigidbody2D> ();
		thrust = ForceMode2D.Impulse;
	}

	public void OnCollisionEnter2D(Collision2D collN)
	{

		if (collN.gameObject.tag == "CircularBumper") 
		{
			force = 6;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);

			largebumperalternate = Resources.Load <UnityEngine.Sprite>("SpriteArt/largebumperalternate");
			rend = collN.gameObject.GetComponent<SpriteRenderer> ();
			rend.sprite = largebumperalternate;
		}

		else if (collN.gameObject.tag == "WallBumper") 
		{
			force = 8;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);

			if (collN.gameObject.name == "bottomleftbumper") 
			{
				bottomleftbumperalternate = Resources.Load <UnityEngine.Sprite>("SpriteArt/bottomleftbumperalternate");
				rend = collN.gameObject.GetComponent<SpriteRenderer> ();
				rend.sprite = bottomleftbumperalternate;
			}

			else if (collN.gameObject.name == "bottomrightbumper") 
			{
				bottomrightbumperalternate = Resources.Load <UnityEngine.Sprite>("SpriteArt/bottomrightbumperalternate");
				rend = collN.gameObject.GetComponent<SpriteRenderer> ();
				rend.sprite = bottomrightbumperalternate;
				rend.flipX = true;
			}
		}

		else if (collN.gameObject.tag == "SideCircularBumper") 
		{
			force = 11;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);

			sidebumperalternate = Resources.Load <UnityEngine.Sprite>("SpriteArt/sidebumperalternate");
			rend = collN.gameObject.GetComponent<SpriteRenderer> ();
			rend.sprite = sidebumperalternate;
		}
	}

}