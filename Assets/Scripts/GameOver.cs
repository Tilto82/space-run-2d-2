using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool isRestarted;
    public GameObject startUI;
    public GameObject gameUI;
    public GameObject gameOverUI;

    public GameObject player;
    public Transform playerPosition;

    private float _timeLeft = 0.5f;
    public void Restart()
    {
        isRestarted = true;

        gameUI.SetActive(false);
        startUI.SetActive(true);
        gameOverUI.SetActive(false);
    }

    private void Update()
    {
        if (isRestarted)
        {
            _timeLeft -= Time.deltaTime;
            if (_timeLeft < 0)
            {
                isRestarted = false;
            }
            player.SetActive(true);
            player.transform.position = playerPosition.position;
        }
    }
}
