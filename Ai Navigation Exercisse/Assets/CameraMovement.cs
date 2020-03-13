using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float horizontal, vertical, rotation;


    public float movementSpeed, rotationSpeed;

    Vector3 nextTranslation;
    Vector3 nextRotation;
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        nextTranslation = Vector3.zero;
        nextRotation = Vector3.zero;
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        rotation = Input.GetAxisRaw("Rotate");

        nextTranslation.x = horizontal;
        nextTranslation.z = vertical;
        nextTranslation *= movementSpeed * Time.deltaTime;

        if(nextTranslation != Vector3.zero)
            transform.Translate( nextTranslation);

        nextRotation.y = rotation * rotationSpeed * Time.deltaTime;
        transform.Rotate(nextRotation);

        Camera.main.transform.LookAt(transform);
    }
}
