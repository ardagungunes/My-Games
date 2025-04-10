using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    InputAction moveAction;
    Rigidbody playerRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        playerRigidBody.linearVelocity = new Vector3(moveValue.x, playerRigidBody.linearVelocity.y, moveValue.y); 
        

    }
}
