using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public Sprite newSprite;
	public Sprite newSprite1;
    public Sprite newSprite2;
	public Sprite newSprite3;
    public Sprite[] sprites;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;

        if (health == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

		if (health == 3)
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = newSprite1;
		}

        if (health == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite2;
        }

		if (health == 1)
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = newSprite3;
		}

        else if (health <= 0)                      //if our health gets to zero
        {
            DestroyObject(gameObject);       //then destroy
        }
    
       


}
