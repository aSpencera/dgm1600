using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreaker : MonoBehaviour {

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);

    }
}
