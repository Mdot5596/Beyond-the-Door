using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject keyPrefab;
    public Transform keySpawnPoint;
    private int enemiesInRoom;

    void Start()
    {
        // Only get enemies that are children of this room (to avoid grabbing global ones)
        EnemyAI[] enemies = GetComponentsInChildren<EnemyAI>();
        enemiesInRoom = enemies.Length;

        foreach (EnemyAI enemy in enemies)
        {
            enemy.roomManager = this; // Tell each enemy who their manager is
        }
    }

    public void EnemyDefeated()
    {
        enemiesInRoom--;

        if (enemiesInRoom <= 0)
        {
            Instantiate(keyPrefab, keySpawnPoint.position, Quaternion.identity);
        }
    }
}
