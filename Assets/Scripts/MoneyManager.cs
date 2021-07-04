using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    private Player player;
    public GameObject otherGameObject;

    public Text moneyText;
    public int money;
    public int moneyStorage;

    public GameObject secondOtherGameObject;
    private GameOver gameOver;
    private void Update()
    {
        gameOver = secondOtherGameObject.GetComponent<GameOver>();

        if (otherGameObject != null)
        {
            player = otherGameObject.GetComponent<Player>();

            money = player.coinCount;

            moneyText.text = $"{money}";
        }

        if (gameOver.isRestarted)
        {
            moneyStorage += money;
            money = 0;
        }
    }
}
