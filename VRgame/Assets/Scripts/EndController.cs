using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.state == GameManager.StateType.END)
        {
            endScreen();
        }
    }

    public void endScreen()
    {
        transform.position = player.transform.position + player.transform.forward/2f;
        transform.eulerAngles = new Vector3(360, 0, 360) - player.transform.forward;
        Debug.Log(GameManager.state.ToString());
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
