using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunnerScriptZ : MonoBehaviour {

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float yMin;

	[SerializeField]
	private float zMin;

	[SerializeField]
	private float xMax;

	[SerializeField]
	private float yMax;

	[SerializeField]
	private float zMax;


	public Transform target;

	void Start ()
	{
		target = GameObject.Find ("Player").transform;
	}


	void Update ()
	{
		transform.position = new Vector3 (Mathf.Clamp (target.position.x, xMin, xMax), Mathf.Clamp (target.position.y, yMin, yMax), Mathf.Clamp (target.position.z, zMin, zMax));
	}



}
