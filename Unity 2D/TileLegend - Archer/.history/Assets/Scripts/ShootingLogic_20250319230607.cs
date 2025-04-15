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
        ShootArrow();
    }

    void ShootArrow(){
        arrowRigidBody.velocity = new Vector2(xSpeed, 0f);
        if (xSpeed < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 135f); // -45 + 180 to flip the arrow
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -45f);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemies"))
    }
}



