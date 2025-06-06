using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] floatrunSpeed;
    Vector2 moveInput;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void Run(){
        Vector2 playerVelocity = new Vector2(moveInput.x, 0f) * 7f;
        rigidbody2D.velocity = playerVelocity;
    }
}
