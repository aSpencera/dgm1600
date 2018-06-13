using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {


	public Animator anim;



	void Start () 
	{
		anim = GetComponent<Animator>();
	}


	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.transform.tag == "Player")
		{
			anim.Play ("HealthPack");
		}
	}
		
}
