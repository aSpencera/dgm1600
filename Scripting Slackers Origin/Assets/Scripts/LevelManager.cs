using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    //public Manager manager;


    public void levelLoader(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}


    //private void Start()
   // {
      //  manager = GameObject.Find("Manager").GetComponent<Manager>();
   // }

   // private void OnTriggerEnter(Collider collider)
    //{
      //  if (collider.GetComponent<DosPlayerMovement>())
       //     SceneManager.(sceneName);
    //}






