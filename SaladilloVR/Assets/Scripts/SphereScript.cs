///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SphereScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
	// Material de la esfera cuando no está siendo mirada
	public Material SphereMaterial;
	// Material de la esfera cuando está siendo mirada
	public Material SphereHoverMaterial;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<Renderer>().material = SphereMaterial;
	}

	/// <summary>
	/// Método que se ejecuta cuando se empieza a mirar la esfera.
	/// </summary>
	/// <remarks>
	/// Cambia el material de la esfera al indicado que se debe mostrar
	/// cuando se mira la esfera.
	/// </remarks>
	public void HoveredSphere()
	{
		GetComponent<Renderer>().material = SphereHoverMaterial;
	}

	/// <summary>
	/// Método que se ejecuta cuando se deja de mirar la esfera.
	/// </summary>
	/// <remarks>
	/// Cambia el material de la esfera al indicado que se debe mostrar
	/// cuando se deja de mira la esfera.
	/// </remarks>
	public void NotHoveredSphere()
	{
		GetComponent<Renderer>().material = SphereMaterial;
	}
}
