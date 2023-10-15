using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour {
    public Text coinScore;

    void Update() 
    {

        coinScore.text = GameManager.coin.ToString() + " COINS"; //we get the static int from gamemanager and display it
    }
}
