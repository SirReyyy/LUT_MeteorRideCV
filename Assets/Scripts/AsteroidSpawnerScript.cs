using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    private Singleton _singletonManager;
    public GameObject asteroidPrefab;
    public Transform asteroidHolder;

    public float maxTime = 5.0f;
    private float timer = 0.0f;
    private float bounds_X = 8.5f, bounds_Y = 10.0f;


    void Start() {
        _singletonManager = Singleton.Instance;
    } //-- start end

    void FixedUpdate() {
        // if(_singletonManager.gameState != Singleton.GameState.PlayState) {
        //    return;
        // }

        if(timer > maxTime) {
            GameObject asteroid = Instantiate(asteroidPrefab);

            int randomInt = Random.Range(0, 4);
            switch(randomInt)
            {
                case 0:
                    asteroid.transform.position = transform.position + new Vector3(Random.Range(bounds_X, -bounds_X), bounds_Y, 0);
                    break;
                case 1:
                    asteroid.transform.position = transform.position + new Vector3(Random.Range(bounds_X, -bounds_X), -bounds_Y, 0);
                    break;
                case 2:
                    asteroid.transform.position = transform.position + new Vector3(bounds_X, Random.Range(bounds_Y, -bounds_Y), 0);
                    break;
                case 3:
                    asteroid.transform.position = transform.position + new Vector3(-bounds_X, Random.Range(bounds_Y, -bounds_Y), 0);
                    break;
                default: break;
            }

            asteroid.transform.parent = asteroidHolder;
            timer = 0;
        }

        timer += Time.deltaTime;
    } //-- Update end

} //-- class end


/*
Project: 
Made by: 
*/

