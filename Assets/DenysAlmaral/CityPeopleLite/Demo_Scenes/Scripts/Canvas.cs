using UnityEngine;

public class SyncCanvasWithCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Transform canvasTransform;

    void LateUpdate()
    {
        if (mainCamera != null && canvasTransform != null)
        {
            canvasTransform.position = mainCamera.transform.position;
        }
    }
}
