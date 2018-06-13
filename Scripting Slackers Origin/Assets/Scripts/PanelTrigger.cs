using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour {



	public GameObject mapPanel;



	void Start()
	{
		mapPanel.SetActive(false);
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			mapPanel.SetActive(true); 
		}
	}

	private void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			mapPanel.SetActive(false); 
		}
	}
}
