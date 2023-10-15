using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{   
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    //the f is because we're using float
    [SerializeField] //the variable shows up in the inspector despite being private
    private float forwardForce = 2000f;
    [SerializeField]
    private float rightForce = 500f;
    [SerializeField]
    private float leftForce = -500f;
    [SerializeField]
    private float upwardForce = 100f;

    public Transform playerPos;

    // Update is called once per frame
    //Fixed is added when working with Unity physics so that it runs smoother 
    public void FixedUpdate()
    {
        //Time.deltaTime is so the speed isn't dependent on the framerate
        
        if( Input.GetKey("d")){
            rb.AddForce(rightForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        } 
        /*if( Input.GetKey("w")){
            //Adds a forward force on the z-axis
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }*/
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if( Input.GetKey("a")){
            rb.AddForce(leftForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }
        /*if( Input.GetKey("s")){
            rb.AddForce(0, 0 , backwardForce * Time.deltaTime);
        }*/
        if(rb.position.y < -1f) {
            //connects gamemanagers endgame function to this script
            FindObjectOfType<GameManager>().EndGame();
        }
        if (Input.GetKey("space") & playerPos.position.y >= 0.9 & playerPos.position.y <= 1.1 & Shop.jumpUnlock == true)
        {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }

    }
}
