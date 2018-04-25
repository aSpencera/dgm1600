using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletFire : MonoBehaviour {

	public int rotationOffset = -90;
	public Rigidbody2D bullet;
	public float bulletSpeed = 300f;
    public AudioClip hitSound;


    // Update is called once per frame
    void Update () 
	{
		Fire ();

		// subtracting the position of the player from the mouse position
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		difference.Normalize ();			//normalizing the vector. Meaning that all the sum of the vector will be equal to 1

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;	// find the angle in degrees
		transform.rotation = Quaternion.Euler (0f,0f,rotZ + rotationOffset);


	}


	void Fire ()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			var firedBullet = Instantiate (bullet, transform.position, transform.rotation);
			firedBullet.AddForce (transform.up * bulletSpeed);

            AudioSource.PlayClipAtPoint(hitSound, transform.position);
        }
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag == "Enemy")
		{
			Destroy (this.gameObject);
		}
	} 

}
