using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
