using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollisionScript : MonoBehaviour
{
    private float scorevalue;
    public float totalcoins;

     int CoinScore;
    
    public float timeleft;

    public int timeRemaining;

    public Text CoinCounter;
    public Text TimerText;

    private float TimerValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        TimerText.text = "Timer: " + timeRemaining.ToString();
        if (CoinScore == totalcoins)
        {
            if (timeleft <= TimerValue)
            {
                SceneManager.LoadScene("GameWin");
            }
        }
        else if (timeleft <= 0)
        {
            SceneManager.LoadScene("GameLose");
        }
        CoinCounter.text = "Score: " + CoinScore;
        if (CoinScore >= 60)
        {
            SceneManager.LoadScene("GameWin");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinScore += 10;
            Destroy(other.gameObject);
            CoinCounter.text = "Score: " + CoinScore;
        }
    }
}
