using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Personaje 2 que recibe la interfaz y la implementa de una forma diferente al Personaje 1 (corre antes de saltar)
public class Asesino : MonoBehaviour, IVuelo
{
    private GameObject _asesinoTriangulo;
    private Rigidbody _rb;

    public Asesino(GameObject asesinoTriangulo)
    {
        _asesinoTriangulo = asesinoTriangulo;
        _rb = _asesinoTriangulo.GetComponent<Rigidbody>();
    }

    public void Despegar()
    {
        if (_rb != null && Mathf.Abs(_rb.velocity.y) < 0.01f)
        {
            _rb.AddForce(Vector3.up * 300f);
        }
    }

    public void VolarContinuo()
    {
        if (_rb != null)
        {
            _rb.AddForce(Vector3.up * 1f);
        }
    }

}
