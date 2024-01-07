using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{

    public static float xDimesion = 9.26f;
    public static float yDimesion = 3.53f;

    public static bool IsKeyPressed(KeyCode key)
    {
        return Input.GetKey(key);
    }

    public static void MoveLeft(Transform tr, float speed)
    {
        if (tr.position.x > -xDimesion)
        {
            tr.position += new Vector3(-speed, 0, 0);
        }

    }

    public static void MoveRight(Transform tr, float speed)
    {
        if (tr.position.x < xDimesion)
        {
            tr.position += new Vector3(speed, 0, 0);
        }
    }

    public static void MoveUp(Transform tr, float speed)
    {
        if (tr.position.y < yDimesion)
        {
            tr.position += new Vector3(0, speed, 0);
        }
    }

    public static void MoveDown(Transform tr, float speed)
    {
        if (tr.position.y > -yDimesion)
        {
            tr.position += new Vector3(0, -speed, 0);
        }

    }

    public static void MoveHorizontalLoop(Transform tr, float speed, bool isLeft = false)
    {

        if (isLeft)
        {
            if (tr.position.x > -xDimesion - 3)
            {
                tr.position += new Vector3(-speed, 0, 0);
            }
            else
            {
                tr.position = new Vector3(xDimesion + 3, tr.position.y, tr.position.z);
            }
        }
        else
        {
            if (tr.position.x < xDimesion + 3)
            {
                tr.position += new Vector3(speed, 0, 0);
            }
            else
            {
                tr.position = new Vector3(-xDimesion - 3, tr.position.y, tr.position.z);
            }
        }
    }
}
