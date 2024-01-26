using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    // This is the speed of the player
    public float speed = 0.01f;
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
}
