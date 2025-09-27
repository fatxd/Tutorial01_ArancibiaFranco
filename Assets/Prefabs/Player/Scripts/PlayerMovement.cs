using UnityEngine;
/// <summary>
/// Permite el comportamiento del movimiento del jugador.
/// </summary>
public class PlayerMoment : MonoBehaviour
{
    #region Atributes
    /// <summary>
    /// Fuerza utilizada para mover el objeto.
    /// </summary>
    private Vector3 forceToApply;
    /// <summary>
    /// Representa el tiempo transcurrido desde la última aplicación de fuerza.
    /// </summary>
    private float timeSinceLastForce;
    /// <summary>
    /// indica el intervalo de tiempo entre cada aplicación de fuerza.
    /// </summary>
    private float intervalTime;
    /// <summary>
    /// Represeta la estrategia de movimiento del jugador.
    /// </summary>
    private IMovementStrategy movementStrategy;
    /// <summary>
    /// Representa a la clase player.
    /// </summary>
    private Player player;
    #endregion

    #region Ciclo de vida del script
    void Start()
    {
        forceToApply = new Vector3(0, 0, 250);
        timeSinceLastForce = 0f;
        intervalTime = 2f;
        player = new Player(5f,5f);
   
        SetMovementStrategy(new SmoothMovement());
        //SetMovementStrategy(new AcelereteMovement());

    }
    private void Update()
    {
        MovePlayer();
    }

    //logica de física
    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }
    }
    #endregion

    #region Logica del script
    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }
    public void MovePlayer()
    {
        movementStrategy.Move(transform, player);
    }
    #endregion
}
