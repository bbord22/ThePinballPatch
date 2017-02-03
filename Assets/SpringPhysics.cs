using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPhysics : MonoBehaviour {

	public float timer = 0;
	public float countDown = 1.1f;
	public SpriteRenderer gre;

	
	void Start () {
		gre = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	void update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			timer += Time.deltaTime;
		}

		if(timer > countDown)
		{
			gre.color = Color.green;
		}
	}
}
