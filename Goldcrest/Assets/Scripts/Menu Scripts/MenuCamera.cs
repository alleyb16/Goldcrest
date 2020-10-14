using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotates camera around
    }
}
