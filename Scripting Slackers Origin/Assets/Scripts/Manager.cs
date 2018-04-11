using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    private static Manager instance = null;

    public Text scoreBoard;
    private int score;

    public Text badiesBooted;
	private int badies;

	public Text tickTock;
	public float timer;
    private float timerSave;


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

        timerSave = timer;
    }


    public void IncrementScore(int value)
    {
        score += value;
        scoreBoard.text = score.ToString();

		score += value;
		scoreBoard.text = score.ToString();
    }

    public void IncrementBadies(int value)
    {
        badies += value;
        scoreBoard.text = badies.ToString();

        badies += value;
        scoreBoard.text = badies.ToString();
    }

    private void Update()
    {
        IncrementTickTock();
    }

    public void IncrementTickTock()
    {
        timer -= Time.deltaTime;
        tickTock.text = ((int)timer).ToString();
    }	
		
}
