﻿using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Debug.Log("Input left");
		}
	}
}
