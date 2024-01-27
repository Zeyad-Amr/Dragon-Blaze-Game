using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // This is the speed of the player
    public float speed = 0.1f;
    public GameObject fireballPrefab;
    public Vector3 objectSize;
    public int frameCount = 0;
    private bool isFireballKeyDown = false;
    private readonly float debounceTime = 0.2f; // Adjust this value based on your desired debounce time
    private float lastFireballTime;
    public Scoring scoring;

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
        DebouncedFireball();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("PlayerMovement.OnCollisionEnter2D: " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Enemy"))
        {

            // Game Over
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }


    void HandleMovement()
    {
        if (Utils.IsKeyPressed(KeyCode.RightArrow))
        {
            Utils.MoveRight(transform, speed, -objectSize.x / 2);
            Utils.FlipX(transform, false);
        }
        if (Utils.IsKeyPressed(KeyCode.LeftArrow))
        {
            Utils.MoveLeft(transform, speed, -objectSize.x / 2);
            Utils.FlipX(transform, true);
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
    void DebouncedFireball()
    {
        // Check if the fireball key is pressed
        if (Utils.IsKeyPressed(KeyCode.Space))
        {
            // Check if it's the first press or if enough time has passed since the last fireball instantiation
            if (!isFireballKeyDown || Time.time - lastFireballTime > debounceTime)
            {
                FireballAction();

                // Update last fireball time and set the flag
                lastFireballTime = Time.time;
                isFireballKeyDown = true;
            }
        }
        else
        {
            // Reset the flag when the key is released
            isFireballKeyDown = false;
        }
    }

    void FireballAction()
    {
        Instantiate(fireballPrefab, new Vector3(transform.position.x + objectSize.x / 2 + 1, transform.position.y, -1f), Quaternion.identity);
        Utils.FlipX(transform, false);
    }
}