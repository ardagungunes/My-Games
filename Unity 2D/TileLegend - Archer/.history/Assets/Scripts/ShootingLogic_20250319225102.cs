using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{

    Rigidbody2D arrowRigidBody;
    [SerializeField] float arrowSpeed = 4f;
    SpriteRendererarrowSpriteRenderer
    PlayerMovement player;

    float xSpeed;

    // Start is called before the first frame update


    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * arrowSpeed;
        arrowSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        arrowRigidBody.velocity = new Vector2(xSpeed, 0f);
        transform.localScale = new Vector2(Mathf.Sign(xSpeed), transform.localScale.y);
    }
}



