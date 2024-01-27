using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private SpriteRenderer objectSprite;
    private Rigidbody2D rb;
    private Collider2D coll;
    // This is the speed of the player
    public float speed = Scoring.GetLevel() * 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EnemyMovement.Start");
        Destroy(gameObject, 10);
        objectSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
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
            Scoring.AddScore(1);
            objectSprite.color = Color.black;
            coll.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.gravityScale = 1;
            StartCoroutine(DestroyEnemy());
        }
    }
    IEnumerator DestroyEnemy()
    {
        Debug.Log("DestroyEnemy");
        yield return new WaitForSeconds(1.5f); // Wait for a short time before destroying the enemy
        Destroy(gameObject);
    }
}
