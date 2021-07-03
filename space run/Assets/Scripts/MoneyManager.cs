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
    private void Update()
    {
        if (otherGameObject != null)
        {
            player = otherGameObject.GetComponent<Player>();

            money = player.coinCount;

            moneyText.text = $"{money}";
        }
    }
}
