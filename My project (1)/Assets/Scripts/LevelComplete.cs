using UnityEngine;
using UnityEngine.SceneManagement;
//used to manage scenes

public class LevelComplete : MonoBehaviour {

    //this triggers after crossing the End of a level
    public void LoadNextLevel() {
        //loads the next scene by getting the build index of the current one and adding 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
