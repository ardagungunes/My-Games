using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Rigidbody2D enemyRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FlipEnemy(){
        enemyRigidBody.velocity = new Vector2(enemyRigidBody.velocity.x * -1f,enemyRigidBody.velocity.y);
    }
}
