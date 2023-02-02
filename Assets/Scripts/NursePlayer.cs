using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NursePlayer : Player
{

    public NursePlayer() //INHERITANCE
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
    public override void PlayerStartPosition() //INHERITANCE
    {
        Vector3 startPos = new Vector3(-5.1f, 0f, 0f);
        transform.position = startPos;
    }

    public override void PlayerStartRotation() //INHERITANCE
    {
        transform.rotation = Quaternion.Euler(0f, 90.0f, 0f);
    }

    public override void PlayerStartScale() //INHERITANCE
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
}
