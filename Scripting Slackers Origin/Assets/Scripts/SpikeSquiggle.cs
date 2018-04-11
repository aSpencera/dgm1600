using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSquiggle : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D Other)
	{
		GetComponent<DosPlayerMovement>().health -= 2;
	}
}
