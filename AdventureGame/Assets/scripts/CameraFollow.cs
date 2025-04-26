using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target; // drag your player here
    public Vector3 offset = new Vector3(0f, 1f, -10f); // adjust for your scene
    public float smoothSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}