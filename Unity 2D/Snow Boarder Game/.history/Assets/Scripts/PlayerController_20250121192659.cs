using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float tor
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            rb.AddTorque(1f);
        }

        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            rb.AddTorque(-1f);
        }
    }
}
