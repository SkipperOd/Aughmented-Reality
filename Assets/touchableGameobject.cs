using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchableGameobject : MonoBehaviour {

	// Use this for initialization
	public Color defaultColor;
	public Color selectedColor;
	private Material mat;

	void Start()
	{
		mat = GetComponent<Renderer>().material;
	}

	void onTouchDown()
	{
		Debug.Log ("working");
		mat.color = selectedColor;

	}

	void onTouchUp()
	{
		mat.color = defaultColor;
	}

	void onTouchStay()
	{
		mat.color = selectedColor;
	}

	void onTouchExit()
	{
		mat.color = defaultColor;
	}
}
