using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{

    [SerializeField] float speed = 10.0f;
    [SerializeField] float rotationSpeed = 50.0f;
     private Vector3 angulo;
   private Quaternion qz = Quaternion.identity;
   private Quaternion qx = Quaternion.identity;
   private Quaternion qy = Quaternion.identity;
   private Quaternion r = Quaternion.identity;

    private float anguloSen;
    private float anguloCos;


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
        
        Movimiento();

    }
    public void Movimiento()
    {
        angulo.z += -horizontalInput * rotationSpeed * Time.deltaTime;
       

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulo.z * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulo.z * 0.5f);
        qz.Set(0, 0, anguloSen, anguloCos);


        angulo.x += -verticalInput * rotationSpeed * Time.deltaTime;
        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulo.x * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulo.x * 0.5f);
        qx.Set(anguloSen, 0, 0, anguloCos);


        angulo.y += horizontalInput * rotationSpeed * Time.deltaTime;
        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulo.y * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulo.y * 0.5f);
        qy.Set(0, anguloSen, 0, anguloCos);

        r = qy * qx * qz;

        transform.rotation = r;
    }
}
