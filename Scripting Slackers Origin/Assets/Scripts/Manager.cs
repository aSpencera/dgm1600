using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {


    public Text scoreBoard;
    private int score;

    public Text badiesBooted;
	private int badies;



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
}
