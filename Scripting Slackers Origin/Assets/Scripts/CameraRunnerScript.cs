using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunnerScript : MonoBehaviour {


	public Transform Player;

	void Update () 
	{
		transform.position = new Vector3 (Player.position.x + 6, 0, -10);
	}
}
