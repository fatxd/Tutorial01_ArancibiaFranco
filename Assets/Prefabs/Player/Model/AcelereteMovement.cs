using UnityEngine;

public class AcelereteMovement : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform transform, Player player, float direction)
    {
        float movement = direction * (player.Velocity + player.Acceleration) * Time.deltaTime;
        transform.Translate(movement * Time.deltaTime, 0, 0);
    }
}
