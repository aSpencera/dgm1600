using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, doorUnlocked, doorLocked, bed, sleep, check};
    public States currentState;

    //"There is an old crusty Bed nearby." 


	// Use this for initialization
	void Start () {
        currentState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (currentState == States.cell)
        {
            Cell();
        }
        else if (currentState == States.bed) { 
            Bed();
        }

		
	}

    private void Cell()
    {
        print("You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, D for Door, B for Bed.\n ");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.D)) { currentState = States.doorLocked; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }

    }
    private void doorLocked()
    {
        print("The Door is locked, you must find the Key before you can leave the Cell.\n " +
           "Would you like to return to the Cell?\n " +
           "Press C for Cell.\n " );
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }


    private void Bed()
    {
        print("You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to Check the bed?\n " +
            "Would you like to return to the Cell?\n " + 
            "Press S for Sleep, Q for Check, C for Cell.\n " );
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.Q)) { currentState = States.check; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void Sleep()
    {
        print("You fell asleep and never tried to escape. \n" +
            "GAME OVER, YOU LOSE!\n ");
    }
    private void Check()
    {
        print("You found a Key under the bed, and decide to keep it!\n " +
            "Would you like to Sleep?\n " + 
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, C for cell.\n ");
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }

    }
    private void Window()
    {

    }
}
