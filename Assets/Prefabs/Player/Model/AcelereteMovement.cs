using UnityEngine;

public class AcelereteMovement : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform transform, Player player)
    {
        currentSpeed += Input.GetAxis("Horizontal") * player.Acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -player.Velocity, player.Velocity);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}
