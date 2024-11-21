using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVuelo
{
    private IVuelo _Vuelo; //Ahora aprendi para que se usa el _, antes no sabia :3
    public SistemaDeVuelo(IVuelo vuelo)
    {
        _Vuelo = vuelo;
    }
    public void Volar()
    {
        _Vuelo.Despegar();
    }
}
