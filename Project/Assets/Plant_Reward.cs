using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Plant_Reward : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject toBePlanted;
    public GameObject plantable_land;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    void Start()
    {
        toBePlanted = GameObject.Find("Random_Flower_Tobeplanted");
        plantable_land = GameObject.Find("Flower0-0");
    }

    public void plantFlower()
    {
        plantable_land.GetComponent<RawImage>().texture = toBePlanted.GetComponent<Image>().mainTexture;
        plantable_land.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
        toBePlanted.SetActive(false);
        GameObject.Find("Down_Arrow").SetActive(false);
        GameObject obj = GameObject.Find("SFX_FLOWER_PLANTED");
        obj.GetComponent<AudioSource>().Play();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // User Mouse Activity is Checked
        if (isColliding())
        {
            plantFlower();

        } else {
            transform.localPosition = new Vector3(775, -395);
        }
    }

    public bool isColliding()
    {
        float localX = transform.localPosition.x;
        float localY = transform.localPosition.y;

        return (localX > -607 && localX < -407 && (localY > -397 && localY < -97));
    }
}