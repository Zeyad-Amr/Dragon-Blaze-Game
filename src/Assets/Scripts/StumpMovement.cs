using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StumpMovement : MonoBehaviour
{
    public float speed = Scoring.GetLevel() * 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StumpMovement.Start");
    }

    // Update is called once per frame
    void Update()
    {
        Utils.MoveHorizontalLoop(transform, speed, 3, true);
    }
}
