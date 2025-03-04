using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Driver;

public class Delivery : MonoBehaviour
{


      

  void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!.");
  }

  void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Package"){
            Debug.Log("Package is picked up!");
      }

      else if(other.tag == "Delivery Point"){
            Debug.Log("Package is delivered succesfully!");

      }
  }
}
