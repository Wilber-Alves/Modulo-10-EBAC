using UnityEngine;

public class BallControllerSinglePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 startingVelocity = new Vector2(5f, 5f);
    public GameManagerSinglePlayer GameManagerSinglePlayer;
    public float speedUpFactor = 1.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetBall()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        transform.position = Vector3.zero;
        rb.linearVelocity = startingVelocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector2 newVelocity = rb.linearVelocity;
            newVelocity.y = -newVelocity.y; // Reverse and increase speed
            rb.linearVelocity = newVelocity;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            rb.linearVelocity = new Vector2(-rb.linearVelocity.x, rb.linearVelocity.y);
            rb.linearVelocity *= speedUpFactor; // Increase speed by 10%
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rb.linearVelocity = new Vector2(-rb.linearVelocity.x, rb.linearVelocity.y);
            rb.linearVelocity *= speedUpFactor; // Increase speed by 10%
        }
        if (collision.gameObject.CompareTag("WallPlayer"))
        {
            GameManagerSinglePlayer.EnemyScores();
            ResetBall();
        }
        else if (collision.gameObject.CompareTag("WallEnemy"))
        {
            GameManagerSinglePlayer.PlayerScores();
            ResetBall();
        }

    }
}