using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;

    /*
    public enum GameState
    {
        TitleState,
        PlayState,
        ScoreState
    }
    [HideInInspector]
    public GameState State = GameState.TitleState;
    [HideInInspector]
    public string player_rfid_serial_number = "";
     */


    public static Singleton Instance {
        get { return instance; }
    } //-- Singleton Instance end

    private void Awake() {
        if (instance == null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    } //-- Awake end

} //-- class end


/*
Project: 
Made by: 
*/

