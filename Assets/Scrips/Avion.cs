using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{

    [SerializeField] float speed = 10.0f;
    [SerializeField] float rotationSpeed = 50.0f;

   float horizontalInput;
   float verticalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * -horizontalInput * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
