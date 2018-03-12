using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour {

	private Vector3 mousePosition;


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton (1)) {
			mousePosition = Input.mousePosition;
		}

	}

}