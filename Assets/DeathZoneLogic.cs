using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZoneLogic : MonoBehaviour {

	public BoxCollider2D deathZone;
	public bool ballIsDead = false;
	public int ballNumber;

	void Start () 
	{
		deathZone = GetComponent<BoxCollider2D> ();
	}

	void OnTriggerEnter2D(Collider2D collR)
	{
		ballNumber = collR.gameObject.GetComponent<BouncerLogic> ().ballNumber;
		ballIsDead = true;

		if (ballNumber == 1) 
		{
			ballNumber = 2;	
			SceneManager.LoadScene("Game");
		}
		else if(ballNumber == 2)
		{
			ballNumber = 3;
			//SceneManager.
		}
	}
	

	void Update () 
	{

	}
}
