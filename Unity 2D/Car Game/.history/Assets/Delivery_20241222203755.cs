using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Driver;

public class Delivery : MonoBehaviour
{


      bool deliveryFlag = false;

  void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!.");
  }

  void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Package"){
            Debug.Log("Package is picked up!");
            Destroy(other);
            deliveryFlag = true;

      }

      else if(other.tag == "Delivery Point"){
            Debug.Log("Package is delivered succesfully!");

      }
  }
}
