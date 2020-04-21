using System;
using TMPro;
using UnityEngine;


public class TimerController : MonoBehaviour
{
    private TextMeshPro timerUI;
    // Start is called before the first frame update
    void Start()
    {
        timerUI = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        timerUI.text = String.Format("{0:00}", GameManager.timeLeft / 60) + ":" + String.Format("{0:00}", GameManager.timeLeft % 60);
    }

}
