using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreLogic : MonoBehaviour 
{
	public Text Score;

	void Start () 
	{
		
	}

	void Update () 
	{
		Score.text = GameObject.Find ("peaBall").GetComponent<BouncerLogic> ().currentScore.ToString ();
	}
}
