using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, 
            horizontalInput * rotationSpeed * Time.deltaTime);
        
    }
}
