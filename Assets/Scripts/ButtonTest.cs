using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Right")
        {
            GameObject.Find("Player").GetComponent<Player>().move = 1;
        }
        else if (gameObject.name == "Left")
        {
            GameObject.Find("Player").GetComponent<Player>().move = -1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GameObject.Find("Player").GetComponent<Player>().move = 0;
    }
}
