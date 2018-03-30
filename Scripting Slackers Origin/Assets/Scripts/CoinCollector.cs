using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {

    public Text countText;
    public int coinNum;

    void Start()
    {
        coinNum = 0;
        countText.text = "Count: " + coinNum.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Blupee")
        {
            other.gameObject.SetActive(false);
            coinNum++;
            countText.text = "Count: " + coinNum.ToString();
        }
    }

    void Update()
    {
        countText.text = "Count: " + coinNum;
    }
}
