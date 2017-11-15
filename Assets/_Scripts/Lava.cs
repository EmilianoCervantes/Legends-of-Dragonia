using UnityEngine;
using System.Collections;
public class Lava : MonoBehaviour {
	public float speed=.0001f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, Time.time*speed, 0));
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "amaru inicial") {
			Application.LoadLevel (3);
		}
	}
}