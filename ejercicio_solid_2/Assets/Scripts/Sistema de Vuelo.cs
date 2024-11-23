using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVuelo //Hace volar a los personajes
{
   
    private IVuelo _vuelo; //Ahora aprendi para que se usa el _, antes no sabia :3


    public SistemaDeVuelo(IVuelo vuelo)
    {
        _vuelo = vuelo;
    }
    public void Volar()
    {
        _vuelo.Despegar();
    }
        public void VolarContinuo()
    {
        _vuelo.VolarContinuo();
    }

}
