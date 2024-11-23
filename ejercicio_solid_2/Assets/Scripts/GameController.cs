using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject _magoTriangulo;
    public GameObject _asesinoTriangulo;

    private SistemaDeVuelo _sistemaVueloMago;
    private SistemaDeVuelo _sistemaVueloAsesino;

    //private float tiempoVueloMago = 0f;
    //private float tiempoVueloAsesino = 0f;
    //private const float tiempoMaximoSalto = 0.2f;

    private void Start()
    {
        //Refes
        Mago mago = _magoTriangulo.GetComponent<Mago>();
        Asesino asesino = _asesinoTriangulo.GetComponent<Asesino>();

        _sistemaVueloMago = new SistemaDeVuelo(mago);
        _sistemaVueloAsesino = new SistemaDeVuelo(asesino);

        // Simula vuelos iniciales (opcional)
        _sistemaVueloMago.Volar();
        _sistemaVueloAsesino.Volar();
    }
}