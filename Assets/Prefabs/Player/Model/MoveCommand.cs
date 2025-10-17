using UnityEngine;

public class MoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;

    public MoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    public void Execute()
    {
        playerMovement.SetMovementStrategy(new SmoothMovement());
        playerMovement.MovePlayer(input);
    }
}

