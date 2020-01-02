// written by Sean

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Audio_Button : MonoBehaviour, IDragHandler, IEndDragHandler
{
    //Really dirty code but get it working
    public GameObject[] Video_Players;

    public static int VIDEO_REMAINING = 3;
    [SerializeField]
    public GameObject[] VIDEOS = new GameObject[VIDEO_REMAINING];
    public readonly int CORRECT_INDEX = -1; // correct index is being loaded

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // User Mouse Activity is Checked
        int destroyed = -1;
        if (img1Collision() && VIDEOS[0] != null) {
            Destroy(GameObject.Find("Video_Holder_1"));
            destroyed = 0;
            choose(destroyed);

        } else if (img2Collision() && VIDEOS[1] != null) {
            Destroy(GameObject.Find("Video_Holder_2"));
            destroyed = 1;
            choose(destroyed);

        } else if (img3Collision() && VIDEOS[2] != null) {
            Destroy(GameObject.Find("Video_Holder_3"));
            destroyed = 2;
            choose(destroyed);
        }
        // Return the button to its original position
        transform.localPosition = new Vector3(0, -300);


    }

    public void realignVideos()
    {
        //if (VIDEO_REMAINING == 2) {
        //    GameObject obj1 = null, obj2 = null;
        //    int ind1 = -1, ind2 = -1;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (VIDEOS[i] != null) {
        //            if (ind1 != -1) {
        //                ind2 = i;
        //                break;
                    
        //            } else ind1 = i;
        //        }
        //    }
        //    obj1 = VIDEOS[ind1]; obj2 = VIDEOS[ind2];

        //    obj1.transform.Translate(new Vector3(-475, obj1.transform.localPosition.y-200));
        //    obj2.transform.Translate(new Vector3(-155, obj2.transform.localPosition.y-200));
        //}
    }

    public void choose(int destroyed)
    {
        /*      Choice was made      */
        bool FULL_SCREEN = false;
        VIDEO_REMAINING -= 1;
        Debug.Log("Destroyed " + destroyed);
        VIDEOS[destroyed] = null;

        if (CORRECT_INDEX == destroyed) {
            // CORRECT VFX, SFX
            FULL_SCREEN = true;
        } else {
            // WRONG VFX, SFX
            if (VIDEO_REMAINING == 1) {
                FULL_SCREEN = true;
            
            }
        }

        if (FULL_SCREEN) {
            // Transition to full screen and play the full video
            // A 'seed of memory' icon pops up;
            // Transition to garden screen
            // Remaining land to plant the seed will be highlighted
            // If touched, a seed is planted
        }
    }

    public bool img1Collision()
    {
        float localX = transform.localPosition.x;
        float localY = transform.localPosition.y;

        if (localX > -924 && localX < -324 && (localY > -100 && localY < 500))
        {
            Debug.Log("Collided with Image 1");
            return true;
        }
        return false;
    }

    public bool img2Collision()
    {
        float localX = transform.localPosition.x;
        float localY = transform.localPosition.y;

        if (localX > -298 && localX < 302 && (localY > -100 && localY < 500))
        {
            Debug.Log("Collided with Image 2");
            return true;
        }
        return false;
    }

    public bool img3Collision()
    {
        float localX = transform.localPosition.x;
        float localY = transform.localPosition.y;

        if (localX > 330 && localX < 930 && (localY > -100 && localY < 500))
        {
            Debug.Log("Collided with Image 3");
            return true;
        }
        return false;
    }

    // Use this for initialization
    void Start()
    {
        /* Fetching VideoRenderers */
        for (int i = 1; i <= 3; i++)
        {
            VIDEOS[i - 1] = GameObject.Find("Video_Holder_" + i.ToString());
        }
    }
}