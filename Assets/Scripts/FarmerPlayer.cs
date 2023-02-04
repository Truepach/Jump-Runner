using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmerPlayer : Player
{

    public FarmerPlayer()
    {
       jumpForce = 700f;
       doubleJumpForce = 400f;
        gravityModifier = 1.5f;
     
    }
    public override Vector3 PlayerStartPosition() //INHERITANCE
    {
        return new Vector3(-5, 0, 0);
    }

    public override Quaternion PlayerStartRotation() //INHERITANCE
    {
        return Quaternion.Euler(0f, 90f, 0f);
    }

    public override void PlayerStartScale()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
