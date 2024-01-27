using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    public float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("FireballMovement.Start");
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Utils.MoveRight(transform, speed, 5);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("FireballMovement.OnCollisionEnter2D: " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Scoring.AddScore(1);
        }
    }

}
