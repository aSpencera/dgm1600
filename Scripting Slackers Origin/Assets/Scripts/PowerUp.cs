using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class PowerUp : MonoBehaviour {


    public enum Power { ScoreBoost, DoubleCoin};
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
                rend.sprite = images[0];
                break;

            default:

                break;
        }
    }


}
