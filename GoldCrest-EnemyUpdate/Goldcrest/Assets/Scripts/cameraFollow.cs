using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform target; // Drag player in from editor
    public float smoothSpeed = 7.5f; //smaller number = longer smooth time
    public Transform obstruction;
    float zoomSped = 2f;

    public Vector3 offset; // Distance of camera from player

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); // Smoothly moves camera from point A to point B
        transform.position = smoothedPosition;

        transform.LookAt(target); // Sets the target (player) as the rotation focus

    }
}
