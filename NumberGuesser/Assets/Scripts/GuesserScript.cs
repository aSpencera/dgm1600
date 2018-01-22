using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour
{

    public int max;
    public int min;
    private int guess;
    public int count;

    // Use this for initialization
    private void Start()
    {
        print("Welcome to Number Guesser");
        print("Pick a number between " + min + " and " + max);

        //Is the value Guess
        NextGuess();

        //Instructions - push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter for correct.");

        max = max + 1;
    }

    private void NextGuess(){
        count--;
        //figure out how to get guess to be more randomized**************************************
        guess = (Random.Range(min, max));
        print("Is the number" + guess + "?");
     }
    

    // Update is called once per frame
    public void Update()
    {   
        if (count <= 0)
        {
            print("Computer Lose!");
        }
        //Up arrow
        else if (Input.GetKeyDown(KeyCode.UpArrow)){
        min = guess;
        NextGuess();
    }

        //Down arrow
       else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
        max = guess;
        NextGuess();
           
        }

        //Enter button
        else if (Input.GetKey(KeyCode.Return))
            print("COMPUTER WIN!");
        //figure out how how to make zero a lose
        {
          
        }
     
    }
}