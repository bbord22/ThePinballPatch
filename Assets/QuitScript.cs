using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class QuitScript : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit ();
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene ("Game");
		}
	}
}
