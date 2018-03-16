using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float speed = 4;
	public float jumpspeed = 55;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0f, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		if (Input.GetKeyDown (KeyCode.Space))
		{
			rb.AddForce (Vector3.up * jumpspeed, ForceMode.Impulse);
		}
	}
}
