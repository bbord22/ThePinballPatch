using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZoneLogic : BouncerLogic 
{
	void OnTriggerEnter2D(Collider2D collR)
	{
		SceneManager.LoadScene ("Game");
	}

}
