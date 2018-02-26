using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    public static LevelManager instance = null;
    public static int brickCount;


    void Awake()
    {
        //Singleton********

        if (instance == null)                               //if instance is not assigned
        {
            instance = this;
        }
        else if (instance != this)                          //then assign instance to this
        {
            Destroy(this.gameObject);                       //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }



    public void LoadLevel(string level)
    {
        brickCount = 0;
        SceneManager.LoadScene(level);
    }


    public void LoadNextLevel()
    {
        brickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
        
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }
    



}