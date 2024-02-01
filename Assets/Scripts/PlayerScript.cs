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

           StartCoroutine(HitEffect());
           _singletonManager.currentHealth = _singletonManager.currentHealth - 15.0f;
           Destroy(other.gameObject);
            
            if(_singletonManager.currentHealth <= 0 ) {
                Destroy(this.gameObject);
            }
        }
    }

    private IEnumerator HitEffect()
    {
        SpriteRenderer playerSprite = GetComponent<SpriteRenderer>();
        Color defaultColor = playerSprite.color;

        playerSprite.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);

        playerSprite.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);

        playerSprite.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);

        playerSprite.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);

        playerSprite.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(0.1f);

        playerSprite.color = defaultColor;
    }

} //-- class end


/*
Project: 
Made by: 
*/

