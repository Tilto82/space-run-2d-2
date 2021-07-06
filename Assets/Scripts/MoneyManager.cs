using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    private Player _player;
    public GameObject otherGameObject;

    public Text moneyText;
    public int money;
    public int moneyStorage;
    public Text moneyStorageText;

    public GameObject secondOtherGameObject;
    private GameOver _gameOver;

    public int speedUpQuantity;
    public int shootSpeedUpQuantity;
    public int shieldQunatity;

    private float _timeLeft = 0.5f;

    private bool _isCounted;
    private void Update()
    {
        _gameOver = secondOtherGameObject.GetComponent<GameOver>();

        if (otherGameObject != null)
        {
            _player = otherGameObject.GetComponent<Player>();

            money = _player.coinCount;

            moneyText.text = $"{money}";
        }

        if (_gameOver.isRestarted && _isCounted == false)
        {
            moneyStorage += money;
            moneyStorageText.text = $"{moneyStorage}";
            money = 0;
            _isCounted = true;

            _timeLeft -= Time.deltaTime;
            if (_timeLeft < 0)
            {
                _isCounted = false;
            }
        }
    }

    public void BuySomething(string productName)
    {
        if (moneyStorage >= 50)
        {
            moneyStorage -= 50;
            if (productName == "SpeedUp")
            {
                speedUpQuantity++;
            }
            else if (productName == "ShootSpeedUp")
            {
                shootSpeedUpQuantity++;
            }
            else if (productName == "Shield")
            {
                shieldQunatity++;
            }

        }
        else
        {
            Debug.Log("Где деньги, Зин?");
        }
    }
}
