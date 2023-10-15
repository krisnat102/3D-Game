using UnityEngine;

public class CoinRespawn : MonoBehaviour
{
    private bool collected = false;
    private string coinKey;

    private void Start()
    {

        coinKey = "CoinCollected_" + gameObject.name; // Generate a unique key for this coin based on its name or position

        if (PlayerPrefs.GetInt(coinKey, 0) == 1) // Check if this coin has been collected in previous sessions
        {
            collected = true;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected)
        {

            collected = true;
            gameObject.SetActive(false);

            PlayerPrefs.SetInt(coinKey, 1); // Save the collected state to PlayerPrefs
            PlayerPrefs.Save();
        }
    }
}
