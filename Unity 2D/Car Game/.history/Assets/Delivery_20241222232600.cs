using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Driver;

public class Delivery : MonoBehaviour
{

      [SerializeField] Driver driver;
      bool deliveryFlag = false;

      void Start() {
      UnityEngine.Color defaultColor = driver.GetComponent<SpriteRenderer>().color;
}

  void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!.");
  }

  void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Package" && !deliveryFlag){

            Debug.Log("Package is picked up!");
            driver.GetComponent<SpriteRenderer>().color = other.GetComponent<SpriteRenderer>().color;
            Destroy(other.gameObject);
            deliveryFlag = true;

      }

      else if(other.tag == "Delivery Point" && deliveryFlag){
            Debug.Log("Package is delivered succesfully!");
            driver.GetComponent<SpriteRenderer>().color = defaultColor;
            deliveryFlag = false;
      }

      else {
            Debug.Log("Package is not picked up!");
      }
  }
}
