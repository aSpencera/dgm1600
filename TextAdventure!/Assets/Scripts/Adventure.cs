using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, doorUnlocked, doorLocked, bed, sleep, check, cellUnlocked};
    public States currentState;
    public Text textObject;

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
        else if (currentState == States.doorLocked)
        {
            DoorLocked();
        }
        else if (currentState == States.window)
        {
            Window();
        }
        else if (currentState == States.doorUnlocked)
        {
            DoorUnlocked();
        }
		else if (currentState == States.check)
        {
            Check();
        }
        else if (currentState == States.sleep)
        {
            Sleep();
        }
        else if (currentState == States.cellUnlocked)
        {
            CellUnlocked();
        }


	}

    private void Cell()
    {
        print("You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, D for Door, B for Bed.\n ");
        textObject.text = "You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, D for Door, B for Bed.\n ";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.D)) { currentState = States.doorLocked; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }

    }
    private void DoorLocked()
    {
        print("The Door is locked, you must find the Key before you can leave the Cell.\n " +
           "Would you like to return to the Cell?\n " +
           "Press C for Cell.\n " );
        textObject.text = "The Door is locked, you must find the Key before you can leave the Cell.\n " +
           "Would you like to return to the Cell?\n " +
           "Press C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }


    //Fix this command for Cell to a new cell with an open door or something to the same effect.   *************
    private void DoorUnlocked()
    {
        textObject.text = "As you turn the Key you hear the gears in the door twisting and turnning and finally... Click!\n " +
            "The Door sweeps open and you see two Hallways. One goes Left and the other Right.\n " +
            "Would you like to go Left?\n " +
            "Would you like to go Right?\n " +
            "Would you like to return to Cell?\n " +
            "Press L to go Left, R to go Right, C for Cell.\n ";
    }
    //After finding the key there should be a new 'bed' when you return to the cell************
    private void Bed()
    {
        print("You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to Check the bed?\n " +
            "Would you like to return to the Cell?\n " + 
            "Press S for Sleep, Q for Check, C for Cell.\n " );
        textObject.text = "You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to Check the bed?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, Q for Check, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.Q)) { currentState = States.check; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void Sleep()
    {
        print("You fell asleep and never tried to escape. \n" +
            "GAME OVER, YOU LOSE!\n ");
        textObject.text = "You fell asleep and never tried to escape. \n" +
            "GAME OVER, YOU LOSE!\n ";
    }
    private void Check()
    {
        print("You found a Key under the bed, and decide to keep it!\n " +
            "Would you like to Sleep?\n " + 
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, C for cell.\n ");
        textObject.text = "You found a Key under the bed, and decide to keep it!\n " +
            "Would you like to Sleep?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, R to return to cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.cellUnlocked; }

    }
    private void Window()
    {
        print("You see a dark rainy sky out the Window and feel like breaking it!\n " +
            "At the moment you have nothing to Smash the Window with.\n " +
            "Would you like to return to the Cell?\n " +
            "Press C to return to Cell.\n ");

    }
    private void CellUnlocked()
    {
        print("You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "You now have a key to open the Door.\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, O to open Door, B for Bed.\n ");
        textObject.text = "You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "You now have a key to open the Door!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, O to open Door, B for Bed.\n ";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.O)) { currentState = States.doorUnlocked; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
}
