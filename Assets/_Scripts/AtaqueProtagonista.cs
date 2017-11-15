using UnityEngine;
using System.Collections;

public class AtaqueProtagonista : MonoBehaviour {
	GameObject enemigo;
	float tiempo=0f;
	//float tiempoMax=1f;
	// Use this for initialization
	void Start () {
		
	}

	//atacar con Q
	void FixedUpdate () {
		if (0 < tiempo) {
			tiempo -= Time.deltaTime;
		} else {
			tiempo = 0f;
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			if (tiempo == 0) {
				Atq ();
				tiempo += 1f;
			}
		}
	}

	void Atq(){
		float dist = Vector2.Distance (enemigo.transform.position, transform.position);
		Vector2 vista = new Vector2 ();
		//vector unitario
		vista = (enemigo.transform.position - transform.position).normalized;
		//producto punto
		//forward: saber si está viendo al enemigo
		float angulo = Vector2.Dot(vista,transform.forward);
		//Con Debug.Log(); podemos comprobar manualmente las cosas

		if(dist<3f && angulo>0.5f){
			SaludVillanos sal = new SaludVillanos ();
			sal.ChecarSalud (10);
		}

	}
}
