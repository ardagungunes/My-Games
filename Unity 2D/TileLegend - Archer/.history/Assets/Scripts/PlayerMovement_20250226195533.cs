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
    float myGravityScale = 8f;
    Vector2 moveInput;

    Rigidbody2D rigidbody2D;
    Animator myAnimator;
    Collider2D myCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCollider2D = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
        ClimbLadder();


    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value){
        if(value.isPressed){
            Jump();
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
        if(myCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground"))){
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
        }
    }

    void ClimbLadder(){
        if(myCollider2D.IsTouchingLayers(LayerMask.GetMask("Ladder"))){
        rigidbody2D.gravityScale = 0f;
        Vector2 climbVelocity = new Vector2(rigidbody2D.velocity.x, moveInput.y * climbSpeed);
        rigidbody2D.velocity = climbVelocity;

        }
    }


}
