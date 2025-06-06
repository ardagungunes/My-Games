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
        Vector2 flip = new Vector2(-enemySpeed, enemyRigidBody.velocity.y);
        transform.localScale
        enemyRigidBody.velocity = flip;
    }

    void MoveEnemy(){
        Vector2 velocity = new Vector2(enemySpeed, enemyRigidBody.velocity.y);
        enemyRigidBody.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D gameObject){
        if(gameObject.tag == "Wall"){
            FlipEnemy();
        }
    }

}
