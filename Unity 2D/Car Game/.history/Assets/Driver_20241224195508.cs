using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowDown = 15f;
    [SerializeField] float speedUp = 30f;

    public void setMoveSpeed(float speedBoost){
        this.moveSpeed += speedBoost;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost Point"){
            this.moveSpeed = speedUp;
        }
    }
}
