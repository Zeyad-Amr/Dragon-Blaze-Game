using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StumpMovement : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Utils.MoveHorizontalLoop(transform, speed, true);
    }
}
