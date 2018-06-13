using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingFire : MonoBehaviour {



	void OnTriggerEnter2D (Collider2D Other)
	{
		if (Other.tag == "Enemy") 
		{
				Destroy (Other.gameObject.transform.gameObject);
		}
	}

}
