using UnityEngine;

public class Player
{
  private float velocity;
  private float acceleration;

    public Player(float velocity, float accleration)
    {
        this.velocity = velocity;
        this.acceleration = accleration;
    }

    public float Velocity { get => velocity; set => velocity = value; }
    public float Acceleration { get => acceleration; set => acceleration = value; }
}
