using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{

    Rigidbody2D arrowRigidBody;
    [SerializeField] float arrowSpeed = 4f;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        arrowRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootArrow();
    }

    void ShootArrow(){
        if(Mathf.Sign(player.transform.localScale.x) == -1){
            arrowSpeed = arrowSpeed * -1f;
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
        }

        arrowRigidBody.velocity = new Vector2(arrowSpeed,0);
    }
}
