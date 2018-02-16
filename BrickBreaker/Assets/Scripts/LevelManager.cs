using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    public static LevelManager instance = null;


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
        SceneManager.LoadScene(level);
    }






}