using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RotacioSO", menuName = "ScriptableObjects/RotacioSO", order = 1)]
public class RotacioSO : ScriptableObject
{
    [Header("Rotacion")]
    [SerializeField] private float velocidad;
    private Transform transform;
    private Quaternion qy = Quaternion.identity;
    private float anguloSen;
    private float anguloCos;
    Quaternion Q = Quaternion.identity;

    public void Rotar()
    {
        anguloSen = Mathf.Sin(Mathf.Deg2Rad * velocidad * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * velocidad * 0.5f);
        qy.Set(0, anguloSen, 0, anguloCos);
        transform.rotation *= qy;
    }
    public void SetTransform(Transform transform)
    {
        this.transform = transform;
    }
}
