using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.state = GameManager.StateType.LOBBY;
    }

    public void StartGame()
    {
        GameManager.Instance.StartTimer(seconds);
    }
}
