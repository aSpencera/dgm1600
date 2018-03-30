using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class PowerUp : MonoBehaviour {


    public enum Power { ScoreBoost, DoubleCoin, Health};
    public Power powerupType;
    public SpriteRenderer rend;
    public Sprite[] images;



	private void Start ()
    {
        rend = GetComponent<SpriteRenderer>();
		
	}

    private void Update()
    {
        switch (powerupType)
        {
            case Power.ScoreBoost:
                rend.sprite = images[0];                //Tab twice for the shortcut
                break;

            default:

                break;
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (powerupType)
        {
            case Power.ScoreBoost:
                break;
            case Power.DoubleCoin:
                break;
            case Power.Health:
                collider.GetComponent<Health>().IncrementHealth(5);
                break;
        }
        Destroy(gameObject);

    }

}
