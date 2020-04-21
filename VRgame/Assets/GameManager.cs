using System.Timers;
using UnityEngine;
public class GameManager
{
    public enum StateType
    {
        ERR = 0,
        LOBBY,
        PAUSE,
        PLAY,
        END
    }
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        }
    }
    public static StateType state;
    private static Timer timer;
    private static Timer UITimer;
    public static int timeLeft = 0;

    public void StartTimer(int newSeconds)
    {
        timer = new Timer();
        UITimer = new Timer();
        timeLeft = newSeconds;
        timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
        UITimer.Elapsed += (sender, e) => timeLeft--;
        timer.Interval = newSeconds*1000;
        UITimer.Interval = 1000; //1 second timer
        UITimer.AutoReset = true;
        timer.Start();
        UITimer.Start();
        state = StateType.PLAY;
    }

    private static void OnTimerElapsed(object source, ElapsedEventArgs e)
    {
        timer.Stop();
        UITimer.Stop();
        timer.Dispose();
        UITimer.Dispose();
        timeLeft--;
        state = StateType.END;
    }
}