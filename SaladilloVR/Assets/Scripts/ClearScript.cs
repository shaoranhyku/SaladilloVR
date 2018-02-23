///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// ClearScript.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour {

	// Objeto con la dirección IP controducida por el usuario
	public Text IpAddress;

	/// <summary>
	/// Método que se ejecuta cuando se pulsa un boton.
	/// </summary>
	/// <remarks>
	/// Borra todo lo introducido.
	/// </remarks>
	public void Click()
	{
		// Se obtiene la dirección IP introducida por el usuario
		IpAddress.GetComponent<Text>().text = "";
	}
}
