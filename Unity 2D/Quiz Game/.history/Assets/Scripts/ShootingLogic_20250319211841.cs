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
    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
        xSpeed = player.transform.localScale.x * arrowSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        ShootArrow();
    }

    void ShootArrow(){

        arrowRigidBody.velocity = new Vector2(arrowSpeed * xSpeed,0);

    }
}
