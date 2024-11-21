using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Personaje 2 que recibe la interfaz y la implementa de una forma diferente al Personaje 1 (corre antes de saltar)
public class Asesino : MonoBehaviour, IVuelo
{
    public void Despegar()
    {
        Debug.Log("El asesino despega mediante una carrera.");
    }
}
