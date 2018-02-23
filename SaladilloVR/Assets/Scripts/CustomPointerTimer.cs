///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// CustomPointerTimer.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPointerTimer : MonoBehaviour
{

	// Objeto compartido por todos los scripts
	public static CustomPointerTimer CPT;

	// Tiempo por defecto que vamos a tener que esperar para que el contador se rellene
	private float _timeToWait = 3f;
	// Temporizador
	private float _timer;
	// Componente Image de la imagen de relleno
	private Image _image;

	// Indica cuando está contando
	[HideInInspector]
	public bool Counting;
	// Indica si ha llegado al final
	[HideInInspector]
	public bool Ended;

	// Awake se invoca antes que Start
	private void Awake()
	{
		// Se comprueba si el objeto está inicializado
		if (CPT == null)
		{
			// Se obtiene el objeto temporizador
			CPT = GetComponent<CustomPointerTimer>();
		}

		// Se obtiene la imagen del reloj
		_image = GetComponentInChildren<Image>();
	}

	private void Update()
	{
		if (Counting)
		{
			// Se incrementa el temporizador la porción del tiempo que ha tardado
			// en renderizar el último Update.
			// De esta manera se tiene un control de tiempo real independientemente
			// de las características de la máquinas
			_timer += Time.deltaTime;
			// Se relena la imagen la cantidad proporcional al temporizador entre el tiempo necesario para pintarlo
			_image.fillAmount = _timer / _timeToWait;
		}
		else
		{
			// Se reinicia el temporizador
			_timer = 0f;
			// Se reinicia el relleno de la imagen
			_image.fillAmount = _timer;
		}

		// Se comprueba si se ha complido el tiempo de espera
		if (_timer >= _timeToWait)
		{
			//Se indica que el contador ha finalizado
			Ended = true;
		}
	}

	/// <summary>
	/// Indica el temporizador, utilizando el tiempo indicado como parámetro.
	/// </summary>
	/// <param name="time">Tiempo de espera.</param>
	public void StartCounting(float time)
	{
		Counting = true;
		Ended = false;
		_timeToWait = time;
	}

	/// <summary>
	/// Para el temporizador.
	/// </summary>
	public void StopCounting()
	{
		Counting = false;
		Ended = true;
	}
}
