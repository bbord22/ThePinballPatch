using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZoneLogic : MonoBehaviour 
{
	public AudioSource soundEffect;

	void OnTriggerEnter2D(Collider2D collR)
	{
		DontDestroyOnLoad (gameObject);
		soundEffect = gameObject.GetComponent<AudioSource> ();
		soundEffect.Play ();
		SceneManager.LoadScene ("Game");
	}

}
