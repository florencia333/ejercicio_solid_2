using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mi personaje 1 que recibe la interfaz para implementarla de forma específica (despega saltando)
//Salta hacia arriba y puede volar manteniendo presionada la telca
public class Mago : MonoBehaviour, IVuelo
{
    private GameObject _magoTriangulo;
    private Rigidbody _rb;

    public Mago(GameObject magoTriangulo)
    {
        _magoTriangulo = magoTriangulo;
        _rb = _magoTriangulo.GetComponent<Rigidbody>();
    }

    public void Despegar() 
    {
        if (_rb != null && Mathf.Abs(_rb.velocity.y) < 0.01f) //Aplica fuerza para que salte y checkea si no esta ya en el aire
        {
            _rb.AddForce(Vector3.up * 300f); 
        }
            
    }

    public void VolarContinuo()
    {
        if (_rb != null) //Aplicar fuerza continua hacia arriba si se mantiene la tecla presionada
        {
            _rb.AddForce(Vector3.up * 1f); //Ajusta la fuerza
        }
    }

}
