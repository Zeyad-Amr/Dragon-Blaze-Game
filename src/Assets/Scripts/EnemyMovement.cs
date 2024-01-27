using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    // This is the speed of the player
    public float speed = Scoring.GetLevel() * 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EnemyMovement.Start");
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Utils.MoveLeft(transform, speed, 5);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("PlayerMovement.OnCollisionEnter2D: " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Fireball"))
        {
            Destroy(gameObject);
        }
    }
}
