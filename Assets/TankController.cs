using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   public float velocidad = 5f; // Velocidad de movimiento

    void Update()
    {
        // Obtener la entrada de teclado horizontal (eje "Horizontal")
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidad * Time.deltaTime;

        // Aplicar el movimiento al objeto
        transform.Translate(movimiento);
    }
}