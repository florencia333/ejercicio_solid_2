using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void InputAction(); 
    public static event InputAction OnMagoSalto;
    public static event InputAction OnMagoVuelo;
    public static event InputAction OnAsesinoSalto;
    public static event InputAction OnAsesinoVuelo;
    public static event InputAction OnAsesinoMoverAdelante;

    // Update is called once per frame
    void Update()
    {
        // Entrada para el Mago
        if (Input.GetKeyDown(KeyCode.W))
        {
            OnMagoSalto?.Invoke(); // Evento de salto
        }
        if (Input.GetKey(KeyCode.W))
        {
            OnMagoVuelo?.Invoke(); // Evento de vuelo continuo
        }

        // Entrada para el Asesino
        if (Input.GetKeyDown(KeyCode.I))
        {
            OnAsesinoSalto?.Invoke(); // Evento de salto
        }
        if (Input.GetKey(KeyCode.I))
        {
            OnAsesinoVuelo?.Invoke(); // Evento de vuelo continuo
        }
        if (Input.GetKey(KeyCode.K))
        {
            OnAsesinoMoverAdelante?.Invoke(); // Evento de movimiento adelante
        }
    }
}
