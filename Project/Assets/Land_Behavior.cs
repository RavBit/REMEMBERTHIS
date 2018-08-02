using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land_Behavior : MonoBehaviour
{
    public static readonly int[] FLOWER_TYPE = {0, 1, 2, 3, 4, 5, 6, 7};
    private static bool[] indices = new bool[38];
    //private static GameObject[][] flowers = new GameObject[7][6];
    private static int numFlowers = 0;

    //public void chooseSpot()
    //{
    //    int ind = -1;
    //    //int thumbInd = 0;
    //    int line = ind / 7;

    //    if (indices[ind]) { // Loading the thumbnails of videos related to the plants of a specific line of choice
    //        //List<int> lst = new List<int>();
    //        //for (int i = 0; i < 6; i++)
    //        //{
    //        //    GameObject obj = flowers[line][i];
    //        //    if (obj != null) {
    //        //        GameObject.Find("Thumbnail_" + thumbInd.ToString()).SetActive();
    //        //        thumbInd += 1;
    //        //    }
    //        //}

    //    } else {
            
    //    }
    //}



    private int getRandomIndex()
    {
        return Random.Range(0, 8);
    }

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < 39; i++)
        {
            indices[i] = false;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
