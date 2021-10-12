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
        //Timer 
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
        //Score Text
        CoinCounter.text = "Score: " + CoinScore;
        //Win condition
        if (CoinScore >= 60)
        {
            SceneManager.LoadScene("GameWin");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //Checking for collision with Coin
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinScore += 10;
            Destroy(other.gameObject);
            CoinCounter.text = "Score: " + CoinScore;
        }
    }
}
