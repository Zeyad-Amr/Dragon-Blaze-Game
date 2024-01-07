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

    }

    // Update is called once per frame
    void Update()
    {
        if (Utils.IsKeyPressed(KeyCode.RightArrow))
        {
            Utils.moveRight(transform, speed);
        }
        if (Utils.IsKeyPressed(KeyCode.LeftArrow))
        {
            Utils.moveLeft(transform, speed);
        }
        if (Utils.IsKeyPressed(KeyCode.UpArrow))
        {
            Utils.moveUp(transform, speed);
        }
        if (Utils.IsKeyPressed(KeyCode.DownArrow))
        {
            Utils.moveDown(transform, speed);
        }
    }
}