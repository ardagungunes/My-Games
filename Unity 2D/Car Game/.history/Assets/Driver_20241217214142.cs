using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    float steerSpeed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, steerSpeed, 0);

    }
}
