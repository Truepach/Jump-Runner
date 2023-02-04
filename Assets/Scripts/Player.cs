using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce { get; set; }
    public float doubleJumpForce { get; set; }
    public float gravityModifier { get; set; }

    public Player()
    {
        jumpForce = 700f;
        doubleJumpForce = 400f;
        gravityModifier = 1.5f;
    }
    public virtual Vector3 PlayerStartPosition()
    {
        return new Vector3(-5, 0, 0);
    }

    public virtual Quaternion PlayerStartRotation()
    {
        return Quaternion.Euler(0f, 90f, 0f);
    }

    public virtual void PlayerStartScale()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}