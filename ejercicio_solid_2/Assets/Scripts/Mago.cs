using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mi personaje 1 que recibe la interfaz para implementarla de forma específica (despega saltando)
public class Mago : MonoBehaviour, IVuelo
{
    public void Despegar()
    {
        Debug.Log("El mago despega mediante un salto.");
    }
}
