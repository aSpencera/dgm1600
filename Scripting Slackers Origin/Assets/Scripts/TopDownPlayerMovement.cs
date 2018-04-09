using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class TopDownPlayerMovement : MonoBehaviour
{

    private Rigidbody rigid;
    public float speed;  
    public float jump;
    public bool isGrounded;


    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
	{
		//Check for button pushes

		if (Input.GetAxisRaw ("Horizontal") > 0.1f || Input.GetAxisRaw ("Horizontal") < -0.1f)
		{
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime, 0f, 0f));
		}


		if (Input.GetAxisRaw ("Vertical") > 0.1f || Input.GetAxisRaw ("Vertical") < -0.1f)
		{
			transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * speed * Time.deltaTime, 0f));
		}
	}



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = false;
        }
    }







}
