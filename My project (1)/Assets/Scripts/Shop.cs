using UnityEngine;

public class Shop : MonoBehaviour
{

    public static bool jumpUnlock = false;
    public static bool jumpPad = false;

    public void Jump()
    {
        if(GameManager.coin >= 20 && jumpUnlock == false)
        {
            GameManager.coin = GameManager.coin - 20;
            jumpUnlock = true;
        }
        else if(GameManager.coin <= 20)
        {
            Debug.Log("No money");
        }
        else
        {
            Debug.Log("Already has jump");
        }
    }

    public void JumpPad()
    {
        if (GameManager.coin >= 10 && jumpPad == false)
        {
            GameManager.coin = GameManager.coin - 10;
            jumpPad = true;
        }
        else if(GameManager.coin <= 10)
        {
            Debug.Log("No money");
        }
        else
        {
            Debug.Log("Already has jump pad");
        }
    }
}
