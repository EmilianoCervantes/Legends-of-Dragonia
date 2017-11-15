using UnityEngine;
using System.Collections;

public class Fondo : MonoBehaviour {
	public float speed=0.22f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0f, Time.time * speed);
	}
}
