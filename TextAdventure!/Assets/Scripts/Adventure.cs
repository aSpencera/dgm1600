using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, breakingWindow, brokenWindow, windowUnlocked, doorUnlocked, doorLocked, bed, bedChecked, bedOpenChecked, sleep, check, cellUnlocked, leftHallway,leftHallwayHammer, rightHallway, cellOpen, doorOpen, tree, jump};
    public States currentState;
    public Text textObject;



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
        else if (currentState == States.leftHallway)
        {
            LeftHallway();
        }
        else if (currentState == States.rightHallway)
        {
            RightHallway();
        }
        else if (currentState == States.doorOpen)
        {
            DoorOpen();
        }
        else if (currentState == States.cellOpen)
        {
            CellOpen();
        }
        else if (currentState == States.bedChecked)
        {
            BedChecked();
        }
        else if (currentState == States.breakingWindow)
        {
            BreakingWindow();
        }
        else if (currentState == States.brokenWindow)
        {
            BrokenWindow();
        }
        else if (currentState == States.tree)
        {
            Tree();
        }
        else if (currentState == States.jump)
        {
            Jump();
        }
        else if (currentState == States.windowUnlocked)
        {
            WindowUnlocked();
        }
        else if (currentState == States.bedOpenChecked)
        {
            BedOpenChecked();
        }
        else if (currentState == States.leftHallwayHammer)
        {
            LeftHallwayHammer();
        }
    }
    
    private void Cell()
    {
        textObject.text = "You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, D for Door, B for Bed.\n ";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.D)) { currentState = States.doorLocked; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }

    }
    private void CellOpen()
    {
        textObject.text = "You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
            "You now have a Hammer!\n " +
            "There is a Window.\n " +
            "There is a Door.\n " +
            "There is a Bed.\n " +
            "Press W for Window, D for Door, B for Bed.\n ";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.breakingWindow; }
        if (Input.GetKeyDown(KeyCode.D)) { currentState = States.doorOpen; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bedOpenChecked; }

    }
    private void CellUnlocked()
    {
        textObject.text = "You are in an old dark cell, and you think to yourself, Todays the day I get outta here!\n " +
             "You now have a key to open the Door!\n " +
             "There is a Window.\n " +
             "There is a Door.\n " +
             "There is a Bed.\n " +
             "Press W for Window, D for Door, B for Bed.\n ";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.windowUnlocked; }
        if (Input.GetKeyDown(KeyCode.D)) { currentState = States.doorUnlocked; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bedChecked; }
    }
    private void DoorLocked()
    {
        textObject.text = "The Door is locked, you must find the Key before you can leave the Cell.\n " +
           "Would you like to return to the Cell?\n " +
           "Press C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }


    //Fix this command for Cell to a new cell with an open door or something to the same effect.   *************
    private void DoorUnlocked()
    {
        textObject.text = "You use the key in the door. As you turn the Key you hear the gears in the door twisting and turnning and finally... Click!\n " +
            "The Door sweeps open and you see two Hallways. One goes Left and the other Right.\n " +
            "Would you like to go Left?\n " +
            "Would you like to go Right?\n " +
            "Would you like to return to Cell?\n " +
            "Press L to go Left, R to go Right, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.leftHallway; }
        //The count needs to happen after this********
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.rightHallway; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellUnlocked; }
    }
    private void DoorOpen()
    {
        textObject.text = "You open the Door and see two Hallways. One goes Left and the other Right.\n " +
            "Would you like to go Left?\n " +
            "Would you like to go Right?\n " +
            "Would you like to return to Cell?\n " +
            "Press L to go Left, R to go Right, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.leftHallway; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.rightHallway; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellOpen; }
    }


    //After finding the key there should be a new 'bed' when you return to the cell************
    private void Bed()
    {
        textObject.text = "You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to Check the bed?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, Q for Check, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.Q)) { currentState = States.check; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void BedChecked()
    {
        textObject.text = "You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellUnlocked; }
    }
    private void BedOpenChecked()
    {
        textObject.text = "You see an old stained bed resting on the floor.\n " +
            "Would you like to Sleep in the bed?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellOpen; }
    }

    private void Sleep()
    {
        textObject.text = "You fell asleep and never tried to escape. \n" +
            "GAME OVER, YOU LOSE!\n " +
            "Press R to Restart.\n ";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.cell; }
    }
    private void Check()
    {
        textObject.text = "You found a Key under the bed, and decide to keep it!\n " +
            "Would you like to Sleep?\n " +
            "Would you like to return to the Cell?\n " +
            "Press S for Sleep, C to return to cell.\n ";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellUnlocked; }

    }
    private void Window()
    {
        textObject.text = "You see a dark rainy sky out the Window and feel like breaking it!\n " +
            "At the moment you have nothing to Smash the Window with.\n " +
            "Would you like to return to the Cell?\n " +
            "Press C to return to Cell.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void BreakingWindow()
    {
        textObject.text = "You see a dark rainy sky out the Window and feel like breaking it!\n " +
            "You now have a Hammer!\n " +
            "Would you like to Smash the Window?\n " +
            "Would you like to return to the Cell?\n " +
            "Press C to return to Cell, S to Smash the Window.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellOpen; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.brokenWindow; }
    }
    private void BrokenWindow()
    {
        textObject.text = "You stirke the Window with mighty force and the glass shatters!\n " +
            "As you look out you see a Tree, but you think that you might just be able to jump out.\n " +
            "Press J to Jump, T to climb down the Tree.\n ";
        if (Input.GetKeyDown(KeyCode.J)) { currentState = States.jump; }
        if (Input.GetKeyDown(KeyCode.T)) { currentState = States.tree; }
    }
    private void WindowUnlocked()
    {
        textObject.text = "You see a dark rainy sky out the Window and feel like breaking it!\n " +
            "At the moment you have nothing to Smash the Window with.\n " +
            "Would you like to return to the Cell?\n " +
            "Press C to return to Cell.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellUnlocked; }
    }
    private void LeftHallway()
    {
        textObject.text = "As you start to walk down the Hallway you see a gaurd walking towards you!\n " +
            "You need to Escape soon or the Gaurd with catch you!\n " +
            "Press C to return to Cell.\n " +
            "Press R to go down the Right Hallway.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellUnlocked; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.rightHallway; }
    }
    private void LeftHallwayHammer()
    {
        textObject.text = "As you start to walk down the Hallway you see a gaurd walking towards you!\n " +
            "You need to Escape soon or the Gaurd with catch you!\n " +
            "Press C to return to Cell.\n " +
            "Press R to go down the Right Hallway.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellOpen; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.rightHallway; }
    }
    private void RightHallway()
    {
        textObject.text = "You walk down the Right Hallway and find an Almost Empty Room.\n " +
            "On the floor you see a Hammer and decide to keep it.\n " +
            "Would you like to go Left?\n " +
            "Would you like to return to Cell?\n " +
            "Press L to go Left, C for Cell.\n ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellOpen; }
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.leftHallwayHammer; }
    }
    private void Tree()
    {
        textObject.text = "You climb down the tree and safely get to the ground!\n " +
            "You run away and no one is the wiser.\n " +
            "WINNER!\n ";
    }
    private void Jump()
    {
        textObject.text = "You try jumping to freedom, but the fall was to much for you.\n " +
            "You broke both of your legs and could not run away!\n " +
            "GAME OVER, YOU LOSE!\n " +
            "Press R to Restart.\n ";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.cell; }
    }

}
