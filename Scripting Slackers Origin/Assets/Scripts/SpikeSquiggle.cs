using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSquiggle : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D Other)
	{
		if (Other.tag == "Player")
		{
			Application.LoadLevel (0);
			return;
		}

	}
}
