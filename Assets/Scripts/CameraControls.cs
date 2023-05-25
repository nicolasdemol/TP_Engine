using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControls : MonoBehaviour
{
    public float rotationSpeed = 60f;
    public float translationSpeed = 10f;
    public float maxHeight = 2f;
    public float minHeight = -2f;

    private void Update()
    {
        // Rotation horizontale
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        // Translation verticale
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 translation = new Vector3(0f, verticalInput * translationSpeed * Time.deltaTime, 0f);
        Vector3 newPosition = transform.position + translation;
        newPosition.y = Mathf.Clamp(newPosition.y, minHeight, maxHeight);
        transform.position = newPosition;

        // Regarder l'origine du monde
        transform.LookAt(Vector3.zero);
    }
}