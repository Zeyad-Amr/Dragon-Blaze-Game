using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // This is the speed of the player
    public float speed = 0.02f;
    public Vector3 objectSize;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerMovement.Start");
        objectSize = GetComponent<Renderer>().bounds.size;

    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("PlayerMovement.OnCollisionEnter2D: " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Game Over
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }


    void HandleMovement()
    {
        if (Utils.IsKeyPressed(KeyCode.RightArrow))
        {
            Utils.MoveRight(transform, speed, -objectSize.x / 2);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Utils.IsKeyPressed(KeyCode.LeftArrow))
        {
            Utils.MoveLeft(transform, speed, -objectSize.x / 2);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Utils.IsKeyPressed(KeyCode.UpArrow))
        {
            Utils.MoveUp(transform, speed, -objectSize.y / 2);
        }
        if (Utils.IsKeyPressed(KeyCode.DownArrow))
        {
            Utils.MoveDown(transform, speed, -objectSize.y / 2);
        }
    }
}