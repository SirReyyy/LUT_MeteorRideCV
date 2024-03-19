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
    public float minScale, maxScale;
    public bool isRotating = false;
    float asteroidRotSpeed;


    void Start() {
        _singletonManager = Singleton.Instance;

        playerPosition = GameObject.Find("Asher").transform;

        rbody = GetComponent<Rigidbody2D>();
        asteroidRotSpeed = Random.Range(0, 2) * 2 - 1;

        // asteroid scale
        float scale = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(scale, scale, scale);
    } //-- start end

    void Update() {
        // AsteroidHitMouse();
    } //-- Update end


    void FixedUpdate() {
        if(isRotating) {
            rbody.rotation += asteroidRotSpeed;
        }

        var step = asteroidSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, step);
    } //-- FixedUpdate end
} //-- class end


/*
Project: 
Made by: 
*/

