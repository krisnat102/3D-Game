using UnityEngine;
using UnityEngine.UI;
//so we can use ui variables
public class Score : MonoBehaviour {
    public Transform player;
    //an ui variable 
    public Text scoreText;
   
    void Update() {
        //"0" is so that its a whole number. "1" would make it have 1 number after the decimal point
        scoreText.text = player.position.z.ToString("0");

    }
}
