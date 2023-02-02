using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmerPlayer : Player
{

    public FarmerPlayer()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 2)
        {
            jumpForce = 700f;
            doubleJumpForce = 400f;
            gravityModifier = 1.5f;
        }
        else if (currentScene == 3)
        {
            jumpForce = 800f;
            doubleJumpForce = 450f;
            gravityModifier = 1.3f;
        }
        else
        {
            jumpForce = 500f;
            doubleJumpForce = 400f;
            gravityModifier = 1.5f;
        }
    }
    public override void PlayerStartPosition()
    {
        Vector3 startPos = new Vector3(-5, 0, 0);
        transform.position = startPos;
    }

    public override void PlayerStartRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 9f, 0f);
    }

    public override void PlayerStartScale()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
