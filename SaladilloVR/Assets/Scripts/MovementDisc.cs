///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// MovementDisc.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDisc : MonoBehaviour
{
    // La velocidad máxima de desplazamiento
    public float MaxSpeed = 0.5f;

    // Fuerza de empuje
    public float PushForce = 10f;

    // Indica si el usuario está mirando directamente
    [HideInInspector] public bool IsHover;

    // Referencia al rigidbody que queremos mover;
    public Rigidbody Rigidbody;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsHover)
        {
            if (Rigidbody.velocity.magnitude < MaxSpeed)
            {
                Rigidbody.AddForce((GvrPointerInputModule.Pointer.CurrentRaycastResult.worldPosition -
                                    transform.position).normalized * PushForce);
            }
        }
    }

    /// <summary>
    /// Acciones a realizar para el evento de mirar el disco.
    /// </summary>
    public void StartLookingAtDisc()
    {
        IsHover = true;
    }
    
    /// <summary>
    /// Acciones a realizar para el evento de dejar de mirar el disco.
    /// </summary>
    public void StopLookingAtDisc()
    {
        IsHover = false;
    }
}