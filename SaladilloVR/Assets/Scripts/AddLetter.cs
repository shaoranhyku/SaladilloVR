using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddLetter : MonoBehaviour {

	// Objeto con la dirección IP controducida por el usuario
	public Text IpAddress;

	/// <summary>
	/// Método que se ejecuta cuando se pulsa un boton.
	/// </summary>
	/// <remarks>
	/// Introduce el número pulsado en el texto.
	/// </remarks>
	public void Click()
	{
		// Se obtiene la dirección IP introducida por el usuario
		IpAddress.GetComponent<Text>().text += GetComponentInChildren<Text>().text;
	}
}
