using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {

    public int value;
    private Manager myManager;
	public AudioClip coinSound;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.transform.tag == "Player")
		{
			myManager.IncrementScore (value);
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint (coinSound, collider.transform.position);
		}
	}

   
}
