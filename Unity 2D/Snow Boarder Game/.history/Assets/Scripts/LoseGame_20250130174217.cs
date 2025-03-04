using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    [SerializeField] float delay;
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
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Game is Lost!!!");
        }
    }
}
