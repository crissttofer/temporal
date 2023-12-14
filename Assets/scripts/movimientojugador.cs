using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Obtener la entrada del usuario
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical) * velocidad * Time.deltaTime;

        // Aplicar el movimiento al GameObject
        transform.Translate(movimiento);
    }
}
