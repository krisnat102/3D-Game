using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    private float upwardForce = 500f;

    void OnTriggerEnter()
    {
        if(Shop.jumpPad == true)
        {
            Debug.Log("jump pad");
            rb.AddForce(0, upwardForce * Time.deltaTime, 0 , ForceMode.VelocityChange);
        }
    }
}
