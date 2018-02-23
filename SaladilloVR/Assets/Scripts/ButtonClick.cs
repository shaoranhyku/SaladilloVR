using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
	//GameObject que se modifica cuando se pulsa el botón
	public GameObject ClickObject;
	
	
	// Use this for initialization
	public void Click () {
		// Le cambia el estado al objeto
		ClickObject.SetActive(!ClickObject.activeSelf);
	}
}
