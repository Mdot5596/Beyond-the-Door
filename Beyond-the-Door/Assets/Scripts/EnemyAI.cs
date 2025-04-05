using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRange = 5f;
    public int health = 3;

    private Transform player;
    private Rigidbody2D rb;
public RoomManager roomManager;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < detectionRange)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.MovePosition(rb.position + direction * moveSpeed * Time.deltaTime);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (roomManager == null)
{
    Debug.LogError("roomManager is null on: " + gameObject.name);
}
else
{
    roomManager.EnemyDefeated();
}

            roomManager.EnemyDefeated(); // Notify the right room
            Destroy(gameObject);
        }
    }
}
