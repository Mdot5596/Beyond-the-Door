using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public int enemiesInRoom = 3; // Set this manually or auto-count
    public GameObject keyPrefab;
    public Transform keySpawnPoint;

    public void EnemyDefeated()
    {
        enemiesInRoom--;

        if (enemiesInRoom <= 0)
        {
            Instantiate(keyPrefab, keySpawnPoint.position, Quaternion.identity);
        }
    }
}
