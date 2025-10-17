using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;
    void Start()
    {
        offSet = new Vector3(0, 1, -5);
        playerMovement = FindAnyObjectByType<PlayerMovement>();
    }
    void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet;
    }
}
