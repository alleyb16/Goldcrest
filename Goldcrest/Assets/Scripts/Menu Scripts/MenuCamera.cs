using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public float rotateSpeed;

    void Start()
    {
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotates camera around
    }
}
