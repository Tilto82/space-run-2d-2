using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguages : MonoBehaviour
{
    public GameObject vkButton;
    public GameObject instagramButton;

    public Text contactsReturn;
    public Text settingsReturn;
    public Text restartGame;
    public Text youLose;

    public Text exitButton;
    public Text mainMenuReturnButton;
    public Text contactButton;
    public Text settingsButton;

    public Text tapToPlay;

    public void SetEnglish()
    {
        vkButton.SetActive(false);
        instagramButton.SetActive(true);

        contactsReturn.text = "Back";
        settingsReturn.text = "Back";
        restartGame.text = "On base!";
        youLose.text = "You Lose!";

        exitButton.text = "Exit";
        mainMenuReturnButton.text = "Back";
        contactButton.text = "Contacts";
        settingsButton.text = "Settings";

        tapToPlay.text = "Tap to play!";
    }

    public void SetRussian()
    {
        instagramButton.SetActive(false);
        vkButton.SetActive(true);

        contactsReturn.text = "Назад";
        settingsReturn.text = "Назад";
        restartGame.text = "На базу!";
        youLose.text = "Вы проиграли!";

        exitButton.text = "Выход";
        mainMenuReturnButton.text = "Назад";
        contactButton.text = "Контакты";
        settingsButton.text = "Настройки";

        tapToPlay.text = "Нажмите чтобы играть";
    }
}
