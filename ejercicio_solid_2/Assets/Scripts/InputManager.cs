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
        // Input para el Mago
        if (Input.GetKeyDown(KeyCode.W))
        {
            OnMagoSalto?.Invoke();
        }
        if (Input.GetKey(KeyCode.W))
        {
            OnMagoVuelo?.Invoke();
        }

        // Input para el Asesino
        if (Input.GetKeyDown(KeyCode.I))
        {
            OnAsesinoSalto?.Invoke();
        }

        if (Input.GetKey(KeyCode.I))
        {
            OnAsesinoVuelo?.Invoke();
        }
        if (Input.GetKey(KeyCode.K))
        {
            OnAsesinoMoverAdelante?.Invoke();
        }


    }
}
