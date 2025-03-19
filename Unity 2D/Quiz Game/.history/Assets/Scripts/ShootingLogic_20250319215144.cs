using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{

    Rigidbody2D arrowRigidBody;
    [SerializeField] float arrowSpeed = 4f;
    PlayerMovement player;

    float xSpeed;

    // Start is called before the first frame update


    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
        
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * arrowSpeed;
    }

    void Update()
    {
        arrowRigidBody.velocity = new Vector2(xSpeed, 0f);
    }
}



