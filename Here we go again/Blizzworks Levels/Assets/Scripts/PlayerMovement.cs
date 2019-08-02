using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public Animator animator;

    public int health = 1;
    public float invincibleTimeAfterHurt = 0;
    private object collision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Patrol enemy = collision.collider.GetComponent<Patrol>();
    //    if (enemy != null)
    //    {
    //        Hurt();
    //    }

    //}
    void Hurt()
    {
        health--;
        if (health <= 0)
        {

            Application.LoadLevel(Application.loadedLevel);

        }
    }

}