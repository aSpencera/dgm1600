using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public string levelTag;


    public void levelLoader(string sceneName)
    {
		PlayerPrefs.SetInt (levelTag, 1);
        SceneManager.LoadScene(sceneName);
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






