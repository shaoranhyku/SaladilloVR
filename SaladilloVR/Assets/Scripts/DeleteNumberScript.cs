///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// DeleteNumberScript.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteNumberScript : MonoBehaviour {

	// Objeto con la dirección IP controducida por el usuario
	public Text IpAddress;

	/// <summary>
	/// Método que se ejecuta cuando se pulsa un boton.
	/// </summary>
	/// <remarks>
	/// Borra el último número introducido.
	/// </remarks>
	public void Click()
	{
		if (IpAddress.GetComponent<Text>().text.Length > 0)
		{
			// Se obtiene la dirección IP introducida por el usuario
			IpAddress.GetComponent<Text>().text = IpAddress.GetComponent<Text>().text.Substring(0, IpAddress.GetComponent<Text>().text.Length-1);
		}
	}
}
