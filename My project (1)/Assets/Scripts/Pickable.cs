using UnityEngine;
using UnityEngine.SceneManagement;
public class Pickable : MonoBehaviour 
{
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin") 
        {
            //increases the coin tracker by 1 every time you pick a coin
            GameManager.coin += 1;
            //deactivates the coin after being picked up
            Col.gameObject.SetActive(false);
        }
    }
}
