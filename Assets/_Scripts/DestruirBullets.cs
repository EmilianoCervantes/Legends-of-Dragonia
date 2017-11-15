using UnityEngine;
using System.Collections;

public class DestruirBullets : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
