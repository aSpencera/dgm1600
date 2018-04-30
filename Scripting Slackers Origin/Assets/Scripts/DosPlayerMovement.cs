﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class DosPlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    public float jump;
    public bool isGrounded;
    //public bool flippable;            Make it so I can control whether the player flips or not when moving 
	public float health;
	public Slider healthBar;
	public float maxHealth = 10f;
	public GameObject dedPanel;
	public GameObject finishPanel;
    public AudioClip hitSound;
	public AudioClip finishSound;



    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
		health = maxHealth;
		healthBar.value = health;
		dedPanel.SetActive(false);
		finishPanel.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        //Check for button pushes

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        anim.SetFloat("HorizonGo", Input.GetAxisRaw("Horizontal"));

        

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


		if (health <= 0) 
		{
			dedPanel.SetActive(true);
			Time.timeScale = 0;
		}

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {

            isGrounded = true;

        }

		if (collision.transform.tag == "Enemy") 
		{
			health -= 2;
            healthBar.value = health;
            AudioSource.PlayClipAtPoint(hitSound, collision.transform.position);

        }

		if (collision.transform.tag == "Spike") 
		{
			health -= 5;
			healthBar.value = health;
            AudioSource.PlayClipAtPoint(hitSound, collision.transform.position);
        }

		if (collision.transform.tag == "Fire") 
		{
			health -= 10;
			healthBar.value = health;
            AudioSource.PlayClipAtPoint(hitSound, collision.transform.position);
        }

		if (collision.transform.tag == "FinishLine") 
		{
			AudioSource.PlayClipAtPoint(finishSound, collision.transform.position);
		}

		if (collision.transform.tag == "FinishTrigger") 
		{
			finishPanel.SetActive(true);
			Time.timeScale = 0;
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

