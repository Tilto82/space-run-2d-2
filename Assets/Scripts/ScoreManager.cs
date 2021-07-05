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
    public GameObject secondOtherGameObject;

    void Update()
    {


        ui = otherGameObject.GetComponent<UI>();
        gameOver = secondOtherGameObject.GetComponent<GameOver>();

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
            if (score > maxScore)
            {
                maxScore = score;
                maxScoreText.text = ((int)score).ToString();
            }
            score = 0;

        }
    }
}
