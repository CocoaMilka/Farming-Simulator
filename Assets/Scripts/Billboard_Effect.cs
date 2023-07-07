using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is intended to set a game object's rotation to be the same as the camera's
public class Billboard_Effect : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Automatically sets main camera for every object containing this script :3
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Only rotate via the Y axis of the camera, may change later...
        float yRotation = mainCamera.transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
    }
}
