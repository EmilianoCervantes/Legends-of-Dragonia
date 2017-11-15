using UnityEngine;
using System.Collections;

public class DisparoJugador : MonoBehaviour {


	public static bool ataque = false;
	public Transform bullet;
	public static int orientacion;


	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "FichaDisparo") {
			ataque = true;
		}
	}
	// Update is called once per frame
	void Update () {
		if(ataque == true){
			if(Input.GetKeyDown(KeyCode.Q)){
				Instantiate(bullet, transform.position, Quaternion.identity);
			}

		}
	}

}

