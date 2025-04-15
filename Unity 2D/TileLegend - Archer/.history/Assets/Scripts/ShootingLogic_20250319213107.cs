using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{

    Rigidbody2D arrowRigidBody;
    [SerializeField] float arrowSpeed = 4f;
    [SerializeField] GameObject player;
    float xSpeed;

    // Start is called before the first frame update
     public void SetDirection(float direction)
    {
        xSpeed = direction * arrowSpeed;
    }

    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        arrowRigidBody.velocity = new Vector2(xSpeed, 0);
    }
}


}
