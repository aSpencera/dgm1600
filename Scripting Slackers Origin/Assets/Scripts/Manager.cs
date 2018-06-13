using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    private static Manager instance = null;

    public Text Money;
    private int money;

    public Text badiesBooted;
	private int badies;



    public void Awake()
    {
        if(instance == null)
        {
            instance = this.gameObject.GetComponent<Manager>();
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);

     }


    public void IncrementScore(int value)
    {
        money += value;
        Money.text = money.ToString();

	}

    public void IncrementBadies(int value)
    {
        badies += value;
        badiesBooted.text = badies.ToString();
    }

   
}
