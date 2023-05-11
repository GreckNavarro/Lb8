using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteController : MonoBehaviour
{
    [SerializeField] Transform Mira;
    [SerializeField] RotacioSO rotacion;
    [SerializeField] Transform padre;
    [SerializeField] float velocity;

    private void Start()
    {
        rotacion.SetTransform(transform);
    }

    private void FixedUpdate()
    {
        rotacion.Rotar();
        transform.LookAt(Mira);
        transform.RotateAround(padre.position, Vector3.up, velocity);
    }
}
