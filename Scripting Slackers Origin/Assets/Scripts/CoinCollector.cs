using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {

    public Color colorTint;
    public int value;
    private Manager myManager;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
    }


    private void OnTriggerEnter2D(Collider2D colliider)
    {
        myManager.IncrementScore(value);
        Destroy(gameObject);
    }

   
}
