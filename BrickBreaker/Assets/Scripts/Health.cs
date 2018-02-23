using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite[] sprites;

    private void Awake()
    {
        LevelManager.brickCount++;
        print(LevelManager.brickCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        LevelManager.brickCount--;

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
    
        if(LevelManager.brickCount <= 0)
        {
            
            LevelManager.brickCount--;
            if (LevelManager.brickCount == 0)
            {
                FindObjectOfType<LevelManager>().LoadNextLevel();
            }
            Destroy(gameObject);
        }

    }




}
