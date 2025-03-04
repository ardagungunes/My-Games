using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
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
        if(other.tag == "Player"){
            Invoke("ReloadScene", delay);
            Debug.Log("You Finished the Game!");
        }

    }

    void ReloadScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
