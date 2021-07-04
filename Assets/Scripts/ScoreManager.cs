using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public float maxScore;
    public Text maxScoreText;

    private UI ui;
    public GameObject otherGameObject;
    private GameOver gameOver;

    void Update()
    {


        ui = otherGameObject.GetComponent<UI>();
        gameOver = otherGameObject.GetComponent<GameOver>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (ui.canStart)
            {
                score += 1 * Time.deltaTime;
                scoreText.text = ((int)score).ToString();
            }
        }

        if (gameOver.isRestarted)
        {
            Debug.Log("Da.");
            if (score > maxScore)
            {
                maxScore = score;
                maxScoreText.text = ((int)maxScore).ToString();
            }
            score = 0;
        }
    }
}
