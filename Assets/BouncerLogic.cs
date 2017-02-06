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
	public AudioSource soundEffect;

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
			rb.AddRelativeForce (dir * force, thrust);

			largebumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/largebumperalternate");
			rend = collN.gameObject.GetComponent<SpriteRenderer> ();
			rend.sprite = largebumperalternate;

			soundEffect = collN.gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		} 
		else if (collN.gameObject.tag == "WallBumper") 
		{
			force = 8;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir * force, thrust);
		} 
		else if (collN.gameObject.tag == "sheepbumper") 
		{
			force = 8;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir * force, thrust);

			soundEffect = collN.gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
			soundEffect = GameObject.Find ("largebumperright").GetComponent<AudioSource> ();
			soundEffect.Play ();
		} 
		else if (collN.gameObject.tag == "wallbumper1") 
		{
			force = 12;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir * force, thrust);

			bottomleftbumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomleftbumperalternate");
			rend = GameObject.Find ("bottomleftbumper").GetComponent<SpriteRenderer> ();
			rend.sprite = bottomleftbumperalternate;

			soundEffect = collN.gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		} 
		else if (collN.gameObject.tag == "wallbumper2") 
		{
			force = 12;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir * force, thrust);

			bottomrightbumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomrightbumperalternate");
			rend = GameObject.Find("bottomrightbumper").GetComponent<SpriteRenderer> ();
			rend.sprite = bottomrightbumperalternate;
			rend.flipX = true;

			soundEffect = collN.gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		}

		else if (collN.gameObject.tag == "SideCircularBumper") 
		{
			force = 8;
			dir.x = collN.contacts [0].point.x - collN.gameObject.transform.position.x;
			dir.y = collN.contacts [0].point.y - collN.gameObject.transform.position.y;
			dir = dir.normalized;
			rb.AddRelativeForce (dir*force, thrust);

			sidebumperalternate = Resources.Load <UnityEngine.Sprite>("SpriteArt/sidebumperalternate");
			rend = collN.gameObject.GetComponent<SpriteRenderer> ();
			rend.sprite = sidebumperalternate;

			soundEffect = collN.gameObject.GetComponent<AudioSource> ();
			soundEffect.Play ();
		}
	}

}