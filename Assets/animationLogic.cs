using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationLogic : MonoBehaviour {

	public float startTime;
	public float limit;
	public bool ready = false;

	public void start()
	{
		startTime = 0f;

	}

	void Update () 
	{
		if (gameObject.tag == "CircularBumper") 
		{
			Sprite largebumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomato2");
			Sprite largebumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomatoalt2.1");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == largebumperalternate) {
				if (ready == false) {
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = largebumper;
					ready = false;
				}
			} 
		}

		if (gameObject.tag == "CircularBumper2") 
		{
			Sprite largebumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomato2");
			Sprite largebumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomatoalt2.2");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == largebumperalternate) {
				if (ready == false) {
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = largebumper;
					ready = false;
				}
			} 
		}

		if (gameObject.tag == "CircularBumper3") 
		{
			Sprite largebumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomato2");
			Sprite largebumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/tomatoalt2.3");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == largebumperalternate) {
				if (ready == false) {
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = largebumper;
					ready = false;
				}
			} 
		}

		if (gameObject.name == "bottomleftbumper") 
		{
			Sprite bottomleftbumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomleftbumper");
			Sprite bottomleftbumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomleftbumperalternate");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == bottomleftbumperalternate) {
				if (ready == false) {
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = bottomleftbumper;
					ready = false;
				}
			} 
		}

		if (gameObject.name == "bottomrightbumper") 
		{
			Sprite bottomleftbumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomleftbumper");
			Sprite bottomrightbumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/bottomrightbumperalternate");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == bottomrightbumperalternate) {
				if (ready == false) {
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = bottomleftbumper;
					GetComponent<SpriteRenderer> ().flipX = false;
					ready = false;
				}
			} 
		}

		if (gameObject.tag == "SideCircularBumper") 
		{
			Sprite sidebumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/bellpepper2");
			Sprite sidebumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/bellpepper2alt");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == sidebumperalternate) 
			{
				if (ready == false) 
				{
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) 
				{
					GetComponent<SpriteRenderer> ().sprite = sidebumper;
					ready = false;
				}
			}
		}

		if (gameObject.tag == "lefthorizontalpost") 
		{
			Sprite sheepbumper = Resources.Load <UnityEngine.Sprite> ("SpriteArt/verticalpost");
			Sprite sheepbumperalternate = Resources.Load <UnityEngine.Sprite> ("SpriteArt/finalart/cucumberalt2");
			limit = .1f;

			if (GetComponent<SpriteRenderer> ().sprite == sheepbumperalternate) {
				if (ready == false) 
				{
					startTime = Time.time;
					ready = true;
				}

				if (Time.time - limit > startTime) {
					GetComponent<SpriteRenderer> ().sprite = sheepbumper;
					ready = false;
				}
			} 
		}
	}
}
