
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 10f;
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); //makes the camera follow smoother
        transform.position = player.position + offset; //transform with lower case t refers to the transform of the current object

        //transform.LookAt(player);
    }
}
