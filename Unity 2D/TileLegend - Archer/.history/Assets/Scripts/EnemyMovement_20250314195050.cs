using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 3f;
    Rigidbody2D enemyRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        MoveEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FlipEnemy(){
        enemySpeed = -ene
        Vector2 changeVelocity = new Vector2(-enemySpeed, enemyRigidBody.velocity.y);
        Vector3 flip = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

        transform.localScale = flip;
        enemyRigidBody.velocity = changeVelocity;
    }

    void MoveEnemy(){
        Vector2 velocity = new Vector2(enemySpeed, enemyRigidBody.velocity.y);
        enemyRigidBody.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D gameObject){
        if(gameObject.CompareTag("Wall")){
            FlipEnemy();
        }
    }

}
