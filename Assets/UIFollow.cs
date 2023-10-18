using UnityEngine;

public class UIFollow : MonoBehaviour
{
    public Transform playerCamera;

    void Update()
    {
        transform.position = playerCamera.position + playerCamera.forward * 2f;
        transform.LookAt(playerCamera.position);
    }
}
