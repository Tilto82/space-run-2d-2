using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;

    private UI ui;
    public GameObject otherGameObject;

    void Update()
    {
        ui = otherGameObject.GetComponent<UI>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (ui.canStart == true)
            {
                score += 1 * Time.deltaTime;
                scoreText.text = ((int)score).ToString();
            }
        }    
    }
}
