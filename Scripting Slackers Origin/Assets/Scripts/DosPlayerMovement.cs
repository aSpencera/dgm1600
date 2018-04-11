using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class DosPlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    public float jump;
    public bool isGrounded;
    //public bool flippable;            Make it so I can control whether the player flips or not when moving 
	public int health;
	public float maxHealth = 5f;



    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update()
    {
        //Check for button pushes

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        anim.SetFloat("HorizonGo", Input.GetAxisRaw("Horizontal"));

        if (Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //Flip sprite renderer
            rend.flipX = true;
          
        }
        else if (Input.GetAxisRaw("Horizontal") < 0.1f)
        {
            //Unflip
            rend.flipX = false;
           
        }
        

        if (Input.GetButtonDown("Jump"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.5f, 9);
            if (hit.collider.tag == "Ground")
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }

            if (isGrounded)
            {
                rigid.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }
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
