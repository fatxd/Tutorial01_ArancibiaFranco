using UnityEngine;

public class AcelereteMoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;
    public AcelereteMoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    public void Execute()
    {
        playerMovement.SetMovementStrategy(new AcelereteMovement());
        playerMovement.MovePlayer(input);
    }
}
