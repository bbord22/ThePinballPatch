using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPersistenceLogic : MonoBehaviour 
{
	public AudioSource player;

	void Start () 
	{
		DontDestroyOnLoad (gameObject);	

		if ((FindObjectsOfType (GetType ()).Length > 1) || GameObject.Find("EasterEggTrigger").GetComponent<AudioSource>().isPlaying) 
		{
			Destroy (gameObject);
		}
	}
}
