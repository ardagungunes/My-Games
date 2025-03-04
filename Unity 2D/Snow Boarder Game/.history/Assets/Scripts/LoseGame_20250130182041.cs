using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    [SerializeField] float delay;
    [SerializeField] ParticleSystem particleEffect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Floor"){
            Invoke("ReloadScene", delay);
            Debug.Log("Game is Lost!!!");
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
