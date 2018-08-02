using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Game : MonoBehaviour
{
    public static bool GAME_RUNNING;
    public static bool USER_SUCCESS;
    public static bool ONE_REMAINING = false;
    public readonly int CORRECT_ANS = 1;
    public readonly int WRONG_ANS = 0;

	// Use this for initialization
	void Start ()
    {
        GAME_RUNNING = true;
        USER_SUCCESS = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GAME_RUNNING) {
            if (true) {
                
                USER_SUCCESS = true;
            }
        }
        GAME_RUNNING = false;
	}
}