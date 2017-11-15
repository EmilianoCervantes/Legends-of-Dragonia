using UnityEngine;
using System.Collections;

public class DispararFlechas : MonoBehaviour {
	public Transform Objeto;
	public float Seconds = 3;

	void Start () {
		StartCoroutine(CoroutineShoot());
		//gameObject.transform.rotation.z;
	}

	IEnumerator CoroutineShoot () {
		while (true) {
			Shoot();
			yield return new WaitForSeconds(Seconds);
		}
	}

	void Shoot () {
		Instantiate(Objeto, transform.position, Quaternion.identity);
	}
}