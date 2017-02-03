using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPhysics : MonoBehaviour {

	public float upTime, downTime, pressTime = 0;
	public float countDown = 1.1f;
	public bool ready = false;
	public SpriteRenderer gre;

	
	void Start () {
		gre = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	public void update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && ready == false)
		{
			downTime = Time.time;
			pressTime = downTime + countDown;
			ready = true;
		}

		if(Input.GetKeyUp(KeyCode.Space))
		{
			upTime = Time.time;
		}

		if(upTime >= pressTime && ready == true)
		{
			gre.color = Color.green;
		}
	}
}
