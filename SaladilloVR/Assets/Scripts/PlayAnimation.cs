///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// PlayAnimation.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
	// Tiempo que tardará en activarse el temporizador
	public float ActivationTime = 3f;
	// Objeto que contiene la animación
	public GameObject player;
	
	// Indica si el puntero está sobre el objeto
	private bool _isHover;
	// Indica si la acción se ha realizado
	private bool _executed;
	
	// Update is called once per frame
	private void Update () {
		// Si el usuario está mirando el objeto y el temporizador ha terminado de contar, o si
		// el usuario está mirando el objeto y pulsa el botón Fire1 del mando y la acción aún
		// no se ha ejecuado, relizaremos la acción correspondiente
		if ((_isHover && CustomPointerTimer.CPT.Ended && !_executed) ||
		    (_isHover && Input.GetButtonDown("Fire1") && !_executed))
		{
			// Se indica que ya se ha realizado la acción
			_executed = true;
			// Desactivamos el contador de tiempo del cursor para evitar que se quede bloqueado
			CustomPointerTimer.CPT.StopCounting();
			// Se lanza la animación
			player.GetComponent<Animator>().Play("ScrollDown");
		}
	}

	/// <summary>
	/// Método que llamaremos desde el EventTrigger PointerEnter.
	/// </summary>
	public void StartHover()
	{
		// Indicamos que el objeto está siendo mirado directamente
		_isHover = true;
		// Marcamos como no realizada la acción
		_executed = false;
		// Iniciamos el contador del puntero, indicando el tiempo de activación
		CustomPointerTimer.CPT.StartCounting(ActivationTime);
	}

	/// <summary>
	/// Este método lo llamaremos desde el EventTrigger PointerExist
	/// </summary>
	public void EndHover()
	{
		// Indicado que el objeto ya no está siendo mirado
		_isHover = false;
		// Reiniciamos el contador del puntero
		CustomPointerTimer.CPT.StopCounting();
	}

}
