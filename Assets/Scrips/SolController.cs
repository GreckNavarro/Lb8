using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolController : MonoBehaviour
{
    [SerializeField] RotacioSO rotacionController;


    private void Start()
    {
        rotacionController.SetTransform(transform);
    }

    private void FixedUpdate()
    {
        rotacionController.Rotar();
    }
}
