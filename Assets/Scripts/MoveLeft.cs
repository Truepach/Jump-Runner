using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerController playerControllerScript;
    private float leftBound = -30f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitializePlayerControllerScript());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CheckPlayerControllerScript());
        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator InitializePlayerControllerScript()
    {
        yield return new WaitUntil(() => playerControllerScript != null);
        playerControllerScript = GetComponent<PlayerController>();
    }

    IEnumerator CheckPlayerControllerScript()
    {
        yield return new WaitUntil(() => playerControllerScript != null);

    }

}
