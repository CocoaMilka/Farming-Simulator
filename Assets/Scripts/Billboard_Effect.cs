using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is intended to set a game object's rotation to be the same as the camera's
public class Billboard_Effect : MonoBehaviour
{
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().rotation = camera.GetComponent<Transform>().rotation;
    }
}
