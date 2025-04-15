using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 25f;
    [SerializeField] float runSpeed;
    [SerializeField] float climbSpeed = 3f;
    [SerializeField] float bounceSpeed = 3f;
    bool isAlive = true;
    float myGravityScale = 8f;
    float flingAmount = f;
    Vector2 moveInput;

    Rigidbody2D rigidbody2D;
    Animator myAnimator;
    Collider2D myCollider2D;
    BoxCollider2D feet;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCollider2D = GetComponent<Collider2D>();
        feet = GetComponent<BoxCollider2D>();


    }

    // Update is called once per frame
    void Update()
    {

        if(!isAlive){
            return;
        }

        Run();
        FlipSprite();
        ClimbLadder();
        Bounce();


    }

    void OnMove(InputValue value){
        if(!isAlive){
            return;
        }
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value){
        if(!isAlive){
            return;
        }
        if(value.isPressed){
            Jump();
        }
    }

    void Bounce(){

        if(feet.IsTouchingLayers(LayerMask.GetMask("Bouncing"))){
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed * bounceSpeed);
        }
    }

    void Run(){

        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, rigidbody2D.velocity.y);
        rigidbody2D.velocity = playerVelocity;

        if(Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon){
            myAnimator.SetBool("isRunning", true);
        }
        else{
            myAnimator.SetBool("isRunning", false);
        }
    }

    void FlipSprite(){
        if(rigidbody2D.velocity.x != 0){
        transform.localScale = new Vector2(Mathf.Sign(rigidbody2D.velocity.x), 1f);
        }

    }

    void Jump(){
        if(feet.IsTouchingLayers(LayerMask.GetMask("Ground"))){
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
        }
    }

    void ClimbLadder(){
        if(feet.IsTouchingLayers(LayerMask.GetMask("Ladder"))){
        myAnimator.SetBool("isClimbing", true);
        rigidbody2D.gravityScale = 0f;
        Vector2 climbVelocity = new Vector2(rigidbody2D.velocity.x, moveInput.y * climbSpeed);
        rigidbody2D.velocity = climbVelocity;

        if(climbVelocity.y == 0f){
            myAnimator.SetBool("isClimbing", false);
        }
        }

        else{
            myAnimator.SetBool("isClimbing", false);
            rigidbody2D.gravityScale = myGravityScale;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(!isAlive){
            return;
        }

        if(other.gameObject.CompareTag("Enemy")){
            myAnimator.SetTrigger("isDead");
            Vector2 fling = new Vector2(-rigidbody2D.velocity.x * flingAmount, 20f);
            rigidbody2D.velocity = fling;
            isAlive = false;
        }
    }





}
