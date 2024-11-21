using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Start()
    {
        //Refes
        Mago mago = GameObject.Find("Mago").GetComponent<Mago>();
        Asesino asesino = GameObject.Find("Asesino").GetComponent<Asesino>();

       
        SistemaDeVuelo sistemaVueloMago = new SistemaDeVuelo(mago);
        SistemaDeVuelo sistemaVueloAsesino = new SistemaDeVuelo(asesino);

        
        sistemaVueloMago.Volar();
        sistemaVueloAsesino.Volar();
    }
}