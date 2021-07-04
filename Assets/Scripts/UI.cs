using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private GameOver gameOver;

    public bool canStart;
    public void Play()
    {
        canStart = true;
    }

    public void Pause()
    {
        canStart = false;
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Update()
    {
        gameOver = GetComponent<GameOver>();

        if (gameOver.isRestarted)
        {
            canStart = false;
        }
    }
}
