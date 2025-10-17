using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private List<ICommand> commands;
    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        commands = new List<ICommand>();

    }
    void Update()
    {
        commands.Clear();
        float horizontalInput = Input.GetAxis("Horizontal");
        commands.Add(new MoveCommand(playerMovement, horizontalInput));

        if (Input.GetKey(KeyCode.Space))
        {
            commands.Add(new AcelereteMoveCommand(playerMovement, horizontalInput));
        }
        foreach (var command in commands)
        {
            command.Execute();
        }
    }
}
