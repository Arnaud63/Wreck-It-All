using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMouse : MonoBehaviour
{

    public float mouseSensitivity = 30f;

    private Transform fpsPlayer;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.fpsPlayer = GetComponent<Transform>().root;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        fpsPlayer.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //GetComponent<Transform>().localRotation = Quaternion.Euler(xRotation, 0, 0);
        this.fpsPlayer.localRotation = Quaternion.Euler(xRotation, 0, 0);

    }
}
