using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ClientButtonScript : MonoBehaviour {

	/// <summary>
	/// Este es el método que se ejecuta en OnClick
	/// </summary>
	public void Click()
	{
		// Llama al método que guarda la información del cliente
		LogClient();
	}

	/// <summary>
	/// Guarda la información del cliente.
	/// </summary>
	/// <remarks>
	/// Llama a una corrutina que se conecta con el webAPI para guardar
	/// la información.
	/// </remarks>
	private void LogClient()
	{
		StartCoroutine(LogClientWebApi());
	}

	private IEnumerator LogClientWebApi()
	{
		// Construimos la información que se envia a la webAPI
		WWWForm form = new WWWForm();
		form.AddField("dni", GetComponentInChildren<Text>().text.Split('-')[0].Trim());
		form.AddField("name", GetComponentInChildren<Text>().text.Split('-')[1].Trim());
		 // Crea la petición a la webAPI
		using (UnityWebRequest www = UnityWebRequest.Post(
			Uri.EscapeUriString(string.Format(GameManager.WEB_API_LOG_CLIENTS, GameManager.IpAddress)), form))
		{
			// Envia la petición a la webAPI y espera la respuesta
			yield return www.SendWebRequest();

			// Acción a realizar si la petición se ha ejecutado sin error
			if (!www.isNetworkError)
			{
				// Se accede al audiosourcce del padre y se ejecuta
				GetComponentInParent<AudioSource>().Play();
			}
		}
	}
}
