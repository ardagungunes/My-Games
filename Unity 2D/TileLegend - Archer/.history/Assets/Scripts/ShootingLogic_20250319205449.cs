using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{

    Rigidbody2D arrowRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        arrowRigidBody.velocity = new Vector2(1f,0);
    }
}
