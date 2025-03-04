using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem particleEffect;
    bool hasCrashed = false
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Floor"){
            if(!hasCrashed){
            particleEffect.Play();
            }
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.tag == "Floor"){
            particleEffect.Stop();
        }
    }
}
