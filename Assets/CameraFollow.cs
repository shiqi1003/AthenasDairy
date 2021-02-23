using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        offset = new Vector3(10f, 1f, 0f);

        Vector3 stopPosition = new Vector3(6f, 2f, -46f);
        Vector3 stopPositionr = new Vector3(6f, 2f, -20f);

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        if (smoothPosition.z > stopPosition.z && smoothPosition.z < stopPositionr.z) transform.position = smoothPosition;

        
    }
}
