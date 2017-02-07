using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggLogic : MonoBehaviour {

	public AudioClip sandstorm;
	public AudioSource mainplayer;
	public AudioSource otherplayer;

	void Start () 
	{
		mainplayer = GameObject.Find ("MusicObj").GetComponent<AudioSource>();
		otherplayer = gameObject.GetComponent<AudioSource> ();	
		DontDestroyOnLoad (gameObject);

		if (FindObjectsOfType (GetType ()).Length > 1) 
		{
			Destroy (gameObject);
		} 
	}
	
	void OnTriggerEnter2D()
	{
		if(!(otherplayer.isPlaying))
		{
			sandstorm = Resources.Load <AudioClip> ("AudioFiles/sandstorm");
			GameObject.Find ("MusicObj").SetActive (false);
			otherplayer.GetComponent<AudioSource> ().clip = sandstorm;
			otherplayer.GetComponent<AudioSource> ().Play ();
			otherplayer.GetComponent<AudioSource> ().volume = .8f;
		}
	}
}
