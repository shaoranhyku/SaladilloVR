///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// ScrollDown.cs
///////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animator>().Play("ScrollDown");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
