using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D Other)
	{
		if (Other.tag == "Player")
		{
			Debug.Break ();
			return;
		}
			
		if (Other.gameObject.transform.parent)
		{
			Destroy (Other.gameObject.transform.parent.gameObject);
		}

		else 
		{
			Destroy (Other.gameObject);
		}
	
		
		
		
	}

		



	}
