using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!.");
  }

  void OnTriggerEnter2D(Collider2D other) {
      
        Debug.Log("Triggered");
  }
}
