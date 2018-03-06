/************************************************************
参考URL
	https://teratail.com/questions/24071
************************************************************/
using UnityEngine;
using System.Collections;

/************************************************************
************************************************************/
public class DynamicMaterial : MonoBehaviour {
	/****************************************
	****************************************/
	public Material[] _material;
	public KeyCode Key_ChangeMaterial = KeyCode.A;
	private int i = 0;
	
	/****************************************
	****************************************/
	// Use this for initialization
	void Start () {
		this.GetComponent<Renderer>().material=_material[0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(Key_ChangeMaterial)) { 
			i++; 
			if (i == _material.Length) { 
				i = 0; 
			}
			this.GetComponent<Renderer>().material=_material[i]; 
		}
	}
}
