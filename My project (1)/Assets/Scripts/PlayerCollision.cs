using UnityEngine;
using UnityEngine.SceneManagement;
//used for reseting the game after collision with an obstacle
public class PlayerCollision : MonoBehaviour {
    
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag ==  "Obstacle") {
            //stops the movement after colliding with an obstacle
            movement.enabled = false;
            //connects gamemanagers endgame function to this script
            FindObjectOfType<GameManager>().EndGame();

        }
    }


}
  