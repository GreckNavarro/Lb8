using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField] RotacioSO rotacionController;
    [SerializeField] Transform padre;
    [SerializeField] float velocity;


    private void Start()
    {
        rotacionController.SetTransform(transform);
    }

    private void FixedUpdate()
    {
        rotacionController.Rotar();
        transform.RotateAround(padre.position, Vector3.up, velocity);
    }
}
