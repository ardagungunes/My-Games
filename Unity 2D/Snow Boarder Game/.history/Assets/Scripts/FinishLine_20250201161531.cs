using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float delay;
    [SerializeField] ParticleSystem particleEffect;
    AudioSource audioSource;
    bool hasCrashed = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            audioSource.Play();
            particleEffect.Play();
            Invoke("ReloadScene", delay);
            Debug.Log("You Finished the Game!");
        }

    }

    void ReloadScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
