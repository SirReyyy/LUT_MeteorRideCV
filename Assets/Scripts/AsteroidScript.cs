using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    private Singleton _singletonManager;

    private Rigidbody2D rbody;
    private Transform playerPosition;
    public float asteroidSpeed = 1.0f;
    float asteroidRotSpeed;


    void Start() {
        _singletonManager = Singleton.Instance;

        playerPosition = GameObject.Find("Asher").transform;

        rbody = GetComponent<Rigidbody2D>();
        asteroidRotSpeed = Random.Range(0, 2) * 2 - 1;

        float scale = Random.Range(0.8f, 1.4f);
        transform.localScale = new Vector3(scale, scale, scale);
    } //-- start end

    void Update() {
        
    } //-- Update end


    void FixedUpdate() {
        rbody.rotation += asteroidRotSpeed;

        var step = asteroidSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, step);
    }
} //-- class end


/*
Project: 
Made by: 
*/

