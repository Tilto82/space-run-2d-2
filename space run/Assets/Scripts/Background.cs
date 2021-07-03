using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float backgroundSpeed;
    private UI ui;
    public GameObject otherGameObject;

    void Update()
    {
        ui = otherGameObject.GetComponent<UI>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (ui.canStart == true)
            {
                transform.position += new Vector3(0, backgroundSpeed * Time.deltaTime, 0);
            }
        }
    }
}
