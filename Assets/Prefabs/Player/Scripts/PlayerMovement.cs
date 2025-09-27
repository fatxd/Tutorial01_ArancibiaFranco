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
    /// Indica la velocidad lateral del jugador.
    /// </summary>
    private float velocityLateral;
    #endregion

    #region Ciclo de vida del script
    void Start()
    {
        forceToApply = new Vector3(0, 0, 250);
        timeSinceLastForce = 0f;
        intervalTime = 2f;
        velocityLateral = 2f;

    }
    private void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(direction * velocityLateral * Time.deltaTime,0,0);
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
}
