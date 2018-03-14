using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D Other)
	{
		if (Other.tag == "Player")
		{
			Application.LoadLevel(1);
			return;
		}
			
		if (Other.gameObject.transform)
		{
			Destroy (Other.gameObject.transform.gameObject);
		}

		else 
		{
			Destroy (Other.gameObject);
		}
	
		
		
		
	}

		



	}
