using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float baseSpeed = 30f;
    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    public void DisableControls(){
        return;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost(){
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
            surfaceEffector2D.speed = boostSpeed;
        }
        else{
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
