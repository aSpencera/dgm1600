using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public Sprite newSprite;
	public Sprite newSprite1;
	public Sprite newSprite2;
	public Sprite newSprite3;
	public Sprite newSprite4;
	public Sprite[] sprites;



		private void healthBar ()
		{

			if (GetComponent<DosPlayerMovement>().health == 4)
			{
				gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
			}

			if (GetComponent<DosPlayerMovement>().health == 3)
			{
				gameObject.GetComponent<SpriteRenderer>().sprite = newSprite1;
			}

			if (GetComponent<DosPlayerMovement>().health == 2)
			{
				gameObject.GetComponent<SpriteRenderer>().sprite = newSprite2;
			}

			if (GetComponent<DosPlayerMovement>().health == 1)
			{
				gameObject.GetComponent<SpriteRenderer>().sprite = newSprite3;
			}

			if (GetComponent<DosPlayerMovement>().health <= 0)
			{
				Die ();
				gameObject.GetComponent<SpriteRenderer>().sprite = newSprite4;
			}
		}
    	

    public void Die()
    {
        Destroy(gameObject);
    }


}
