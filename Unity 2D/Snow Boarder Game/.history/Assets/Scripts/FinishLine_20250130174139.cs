using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Invoke("ReloadScene", 2f);
            Debug.Log("You Finished the Game!");
        }

    }

    void ReloadScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
