using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void InitUI();
    public static event InitUI UIInit;
    public static event InitUI EndScreen;

    public delegate void ToggleBackground(bool toggle);
    public static event ToggleBackground BackgroundToggle;

    public static void UI_Init()
    {
        UIInit();
    }
    public static void Background_Toggle(bool toggle)
    {
        BackgroundToggle(toggle);
    }

    public static void End_Screen()
    {
        EndScreen();
    }
}
