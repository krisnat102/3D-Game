using UnityEngine;
using UnityEngine.SceneManagement;
//used to manage scenes
public class GameManager : MonoBehaviour{

    bool gameHasEnded = false;

    public static int coin = 0;

    public float restartDelay = 1f; //how much time it takes to reset the level

    public GameObject completeLevelUI;

    public GameObject coinToSpawn;

    public void CompleteLevel () {
        completeLevelUI.SetActive(true); //after beating the level, makes the ui for beating it appear
    }
    void Restart() { 
           //resets the current level
           SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    public void EndGame() {

        if(gameHasEnded == false) {
            Invoke("Restart", restartDelay);
            Debug.Log("Game Over");
            gameHasEnded = true;
        }
    }
}