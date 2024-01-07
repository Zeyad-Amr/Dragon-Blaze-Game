using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 9.6f)
        {
            transform.Translate(0.05f, 0, 0);
        }
        else
        {
            transform.position = new Vector3(-9.6f, transform.position.y, transform.position.z);
        }
    }
}