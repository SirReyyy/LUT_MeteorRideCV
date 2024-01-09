using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Singleton _singletonManager;
    private UICanvasScript _uiCanvas;
    // public APIManager _apiManager;

    // private AudioSource audioSource;
    // public AudioClip[] audioClips;

    private float currentHealth;

    void Start() {
        _singletonManager = Singleton.Instance;
        
        
    } //-- start end

    void Update() {
        
    } //-- Update end


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Asteroid") {
            /*if (currentHealth <= 0) {
                Destroy(this.gameObject);
            } else {
                currentHealth = currentHealth - 15.0f;
                Destroy(other);
            }*/

           _singletonManager.currentHealth = _singletonManager.currentHealth - 15.0f;
           Destroy(other.gameObject);
            
            if(_singletonManager.currentHealth <= 0 ) {
                Destroy(this.gameObject);
            }
        }
    }

} //-- class end


/*
Project: 
Made by: 
*/

