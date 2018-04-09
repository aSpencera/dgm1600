using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {


    public Text scoreBoard;
    private int score;
	public int badies;


    public void IncrementScore(int value)
    {
        score += value;
        scoreBoard.text = score.ToString();

		badies += value;
		scoreBoard.text = badies.ToString();
    }

	
}
