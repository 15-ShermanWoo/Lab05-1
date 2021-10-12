using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollisionScript : MonoBehaviour
{
    public int CoinScore;
    public Text CoinCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinCounter.text = "Score: " + CoinScore;
        if (CoinScore >= 100)
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
