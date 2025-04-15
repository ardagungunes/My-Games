using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 25f;
    [SerializeField] float runSpeed;
    Vector2 moveInput;
    Rigidbody2D rigidbody2D;
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
        OnJump();
    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void OnJump(InputValue value){
        if()
        Vector2 playerJump = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
        rigidbody2D.velocity = playerJump;
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

    }
}
