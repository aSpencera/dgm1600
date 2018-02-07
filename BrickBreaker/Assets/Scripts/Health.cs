using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;

        if (health <= 0)                      //if our health gets to zero
        {
            DestroyObject(gameObject);       //then destroy
        }
    }



}
