using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
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
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            CoinScore += 10;
            Destroy(collision.gameObject);
            CoinCounter.text = "Score: " + CoinScore;
        }
    }
}
