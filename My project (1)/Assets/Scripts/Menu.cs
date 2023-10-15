using UnityEngine;
using UnityEngine.SceneManagement;
//used to manage scenes
public class Menu : MonoBehaviour {
    
    public void StartGame() {
        //loads the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackShop()
    {
        SceneManager.LoadScene(0);
    }

    public void ShopLoad()
    {
        //loads the last scene, which is the shop
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }

    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        GameManager.coin = 0;
        Shop.jumpPad = false;
        Shop.jumpUnlock = false;
    }
    public void GiveMoney()
    {
        GameManager.coin += 100;

    }


}
