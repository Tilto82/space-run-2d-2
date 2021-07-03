using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
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
}
