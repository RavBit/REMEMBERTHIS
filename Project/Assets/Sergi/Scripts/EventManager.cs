using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void InitUI();
    public static event InitUI UIInit;

    public static void UI_Init()
    {
        UIInit();
    }
}
