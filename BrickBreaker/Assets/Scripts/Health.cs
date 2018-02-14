using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public Sprite newSprite;
    public Sprite newSprite2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;

        if (health == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

        if (health == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite2;
        }

        else if (health <= 0)                      //if our health gets to zero
        {
            DestroyObject(gameObject);       //then destroy
        }
    }



}
