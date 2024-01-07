using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is the speed of the player
    public float speed = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerMovement.Start");
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("PlayerMovement.OnCollisionEnter2D");
    }


    void HandleMovement()
    {
        if (Utils.IsKeyPressed(KeyCode.RightArrow))
        {
            Utils.MoveRight(transform, speed);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Utils.IsKeyPressed(KeyCode.LeftArrow))
        {
            Utils.MoveLeft(transform, speed);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Utils.IsKeyPressed(KeyCode.UpArrow))
        {
            Utils.MoveUp(transform, speed);
        }
        if (Utils.IsKeyPressed(KeyCode.DownArrow))
        {
            Utils.MoveDown(transform, speed);
        }
    }
}