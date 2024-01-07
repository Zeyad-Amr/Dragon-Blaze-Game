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

    public static void moveLeft(Transform tr, float speed)
    {
        if (tr.position.x > -xDimesion)
        {
            tr.position += new Vector3(-speed, 0, 0);
        }

    }

    public static void moveRight(Transform tr, float speed)
    {
        if (tr.position.x < xDimesion)
        {
            tr.position += new Vector3(speed, 0, 0);
        }
    }

    public static void moveUp(Transform tr, float speed)
    {
        if (tr.position.y < yDimesion)
        {
            tr.position += new Vector3(0, speed, 0);
        }
    }

    public static void moveDown(Transform tr, float speed)
    {
        if (tr.position.y > -yDimesion)
        {
            tr.position += new Vector3(0, -speed, 0);
        }

    }
}
