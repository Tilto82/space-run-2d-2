using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    private UI ui;
    public GameObject otherGameObject;

    void Update()
    {
        ui = otherGameObject.GetComponent<UI>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (ui.canStart)
            {
                transform.position += new Vector3(0, cameraSpeed * Time.deltaTime, 0);
            }
        }
    }
}